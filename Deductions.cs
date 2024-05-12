using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BOSS_MIX_PAYROLL_SYSTEM
{
    public partial class Deductions : Form
    {
        private int loggedInUserId;
        private OleDbConnection con;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\Documents\BOSS MIX PAYROLL.accdb";

        public Deductions(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
            con = new OleDbConnection(connectionString);

            dataGridView1.Columns.Add("sss_id", "sss_id");
            dataGridView1.Columns.Add("Range_of_Compensation", "Range_of_Compensation");
            dataGridView1.Columns.Add("Salary_Total", "Salary_Total");
            dataGridView1.Columns.Add("Amount_of_Contribution", "Amount_of_Contribution");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MainForm menuForm = new MainForm(loggedInUserId);
            menuForm.Show();
            this.Hide();
        }

        private void LoadData()
        {
            try
            {
                con = new OleDbConnection(connectionString);
                con.Open();

                string query = "SELECT * FROM Deductions";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Check if the DataTable contains data
                if (dt.Rows.Count > 0)
                {
                    // Clear existing rows from DataGridView
                    dataGridView1.Rows.Clear();

                    // Iterate through the DataTable rows and add them to the DataGridView
                    foreach (DataRow row in dt.Rows)
                    {
                        dataGridView1.Rows.Add(row.ItemArray);
                    }
                }
                else
                {
                    MessageBox.Show("No data found in Deductions table.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void Deductions_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection(connectionString);
                con.Open();

                OleDbCommandBuilder cmdBuilder = new OleDbCommandBuilder((OleDbDataAdapter)dataGridView1.DataSource);
                ((OleDbDataAdapter)dataGridView1.DataSource).UpdateCommand = cmdBuilder.GetUpdateCommand();

                ((OleDbDataAdapter)dataGridView1.DataSource).Update((DataTable)dataGridView1.DataSource);
                MessageBox.Show("Rows updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating rows: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
