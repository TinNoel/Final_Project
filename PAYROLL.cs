using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOSS_MIX_PAYROLL_SYSTEM
{
    public partial class PAYROLL : Form
    {
        private int loggedInUserId;
        private OleDbConnection con;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\BOSS MIX PAYROLL.accdb";
        private Dictionary<string, int> regularRates = new Dictionary<string, int>
        {
            {"Manager", 750},
            {"Sampler/Coordinator", 600},
            {"Loader Operator", 700},
            {"Engineer", 897},
            {"Secretary", 400},
            {"Maintenance", 850},
            {"Truck Driver Helpers", 450},
            {"Driver", 500},
            {"Operator", 500}
        };

        public PAYROLL(int userId)
        {
            InitializeComponent();
            PopulatePositions();
            loggedInUserId = userId;
            con = new OleDbConnection(connectionString);
        }

        private void PopulatePositions()
        {
            foreach (var position in regularRates.Keys)
            {
                comboBox1.Items.Add(position);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm menuForm = new MainForm(loggedInUserId);
            menuForm.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a position.");
                return;
            }

            if (!double.TryParse(textBox1.Text, out double daysWorked))
            {
                MessageBox.Show("Please enter valid days worked.");
                return;
            }

            double.TryParse(overtime.Text, out double overtimeHours);
            double.TryParse(loan.Text, out double loanAmount);
            double.TryParse(bonus.Text, out double bonusAmount);

            string position = comboBox1.SelectedItem.ToString();
            int dailyRate = regularRates[position];
            double rate = Trainee.Checked ? dailyRate * 0.5 : dailyRate;
            double grossSalary = (rate * daysWorked) + ((rate * 1.25) * overtimeHours) + bonusAmount;

            // Retrieve the state of the checkbox to determine if deductions should be applied
            bool applyDeductions = DEDUCTIONS.Checked;
            var (sss, philHealth) = CalculateDeductions(grossSalary, DEDUCTIONS.Checked);

            double totalDeductions = applyDeductions ? sss + philHealth + loanAmount : loanAmount;
            double netSalary = grossSalary - totalDeductions;

            try
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand("INSERT INTO Employee ([emp_name], [position], [emp_type], [pay_date], [rate], [total_salary], [overtime], [loan], [bonus], [sss], [philhealth], [total_deductions]) VALUES (@emp_name, @position, @emp_type, @pay_date, @rate, @total_salary, @overtime, @loan, @bonus, @sss, @philhealth, @total_deductions)", con))
                {
                    int empId = GetNextEmpId(); // Get the next available EMP_ID
                    cmd.Parameters.Add(new OleDbParameter("@emp_name", OleDbType.VarChar)).Value = name.Text;
                    cmd.Parameters.Add(new OleDbParameter("@position", OleDbType.VarChar)).Value = position;
                    cmd.Parameters.Add(new OleDbParameter("@emp_type", OleDbType.VarChar)).Value = RegularEmployee.Checked ? "Regular" : "Trainee";
                    cmd.Parameters.Add(new OleDbParameter("@pay_date", OleDbType.Date)).Value = DateTime.Now;
                    cmd.Parameters.Add(new OleDbParameter("@rate", OleDbType.Double)).Value = rate;
                    cmd.Parameters.Add(new OleDbParameter("@total_salary", OleDbType.Double)).Value = netSalary;
                    cmd.Parameters.Add(new OleDbParameter("@overtime", OleDbType.Double)).Value = overtimeHours;
                    cmd.Parameters.Add(new OleDbParameter("@loan", OleDbType.Double)).Value = loanAmount;
                    cmd.Parameters.Add(new OleDbParameter("@bonus", OleDbType.Double)).Value = bonusAmount;
                    cmd.Parameters.Add(new OleDbParameter("@sss", OleDbType.Double)).Value = sss;
                    cmd.Parameters.Add(new OleDbParameter("@philhealth", OleDbType.Double)).Value = philHealth;
                    cmd.Parameters.Add(new OleDbParameter("@total_deductions", OleDbType.Double)).Value = totalDeductions;

                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update database: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }



            // Assuming PAYSLIP is a form constructor that accepts these parameters
            PAYSLIP payslipForm = new PAYSLIP(name.Text, position, RegularEmployee.Checked ? "Regular" : "Trainee", rate, daysWorked, overtimeHours, bonusAmount, sss, philHealth, loanAmount, totalDeductions, netSalary);
            payslipForm.Show();
        }

        private int GetNextEmpId()
        {
            int nextEmpId = 1;
            try
            {
                // Create a new OleDbConnection object and assign it to the class-level con variable
                con = new OleDbConnection(connectionString);
                con.Open();
                string query = "SELECT MAX(EMP_ID) FROM Employee";
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        nextEmpId = Convert.ToInt32(result) + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get next EMP_ID: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return nextEmpId;
        }

        private (double sss, double philHealth) CalculateDeductions(double grossSalary, bool applyDeductions)
        {
            if (!applyDeductions)
            {
                return (0, 0); // Return no deductions if checkbox is not checked.
            }

            double sss = 0;
            double philHealth = 0;

            // Calculation of SSS based on given salary brackets
            if (grossSalary <= 4000) sss = 180;
            else if (grossSalary <= 4500) sss = 202.50;
            else if (grossSalary <= 5000) sss = 225;
            else if (grossSalary <= 5500) sss = 247.50;
            else if (grossSalary <= 6000) sss = 270;
            else if (grossSalary <= 6500) sss = 292.50;
            else if (grossSalary <= 7000) sss = 315;
            else if (grossSalary <= 8000) sss = 337.50;
            else if (grossSalary <= 8500) sss = 360;
            else if (grossSalary <= 9000) sss = 382.50;
            else if (grossSalary <= 9500) sss = 405;
            else if (grossSalary <= 10000) sss = 427.50;
            else if (grossSalary <= 10500) sss = 450;
            else if (grossSalary <= 11000) sss = 472.50;
            else if (grossSalary <= 11500) sss = 495;
            else if (grossSalary <= 12000) sss = 517.50;
            else if (grossSalary <= 12500) sss = 540;
            else if (grossSalary <= 13000) sss = 562.50;
            else if (grossSalary <= 13500) sss = 585;
            else if (grossSalary <= 14000) sss = 607.50;
            else if (grossSalary <= 14500) sss = 630;
            else if (grossSalary > 14500) sss = 652.50 + ((grossSalary - 14500) / 500) * 22.50;

            // Calculation of PhilHealth based on salary
            if (grossSalary <= 10000) philHealth = 300;
            else if (grossSalary <= 59999) philHealth = 300 + ((grossSalary - 10000) / 50000) * 1500;
            else philHealth = 1800;

            return (sss, philHealth);
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegularEmployee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Trainee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rateperhour_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void overtime_TextChanged(object sender, EventArgs e)
        {

        }

        private void loan_TextChanged(object sender, EventArgs e)
        {

        }

        private void bonus_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void DEDUCTIONS_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
