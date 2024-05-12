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
    public partial class EmployeeRecord : Form
    {
        private int loggedInUserId;
        private OleDbConnection con;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\BOSS MIX PAYROLL.accdb";
        private int empIdCounter = 0; // Initialize counter for EMP_ID

        public EmployeeRecord(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
            con = new OleDbConnection(connectionString);

            // Add columns to DataGridView
            dataGridView1.Columns.Add("EMP_ID", "EMP_ID");
            dataGridView1.Columns.Add("NAME", "NAME");
            dataGridView1.Columns.Add("POSITION", "POSITION");
            dataGridView1.Columns.Add("RATE", "RATE");
            dataGridView1.Columns.Add("PREVIOUS_SALARY", "PREVIOUS SALARY");
            dataGridView1.Columns.Add("CURRENT_SALARY", "CURRENT SALARY");

            // Add employee data
            AddEmployeeData();
        }

        private void AddEmployeeData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT EMP_ID, EMP_NAME, POSITION, RATE, PREVIOUS_SALARY, CURRENT_SALARY FROM [RECORDS]";
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Retrieve data from the database
                                int empId = reader.GetInt32(0);
                                string employeeName = reader.GetString(1);
                                string position = reader.GetString(2);
                                int rate = reader.GetInt32(3);
                                string previousSalary = reader.IsDBNull(4) ? "" : reader.GetInt32(4).ToString();
                                string currentSalary = reader.IsDBNull(5) ? "" : reader.GetInt32(5).ToString();

                                // Add data to the DataGridView
                                dataGridView1.Rows.Add(empId, employeeName, position, rate, previousSalary, "", currentSalary);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee data: " + ex.Message);
            }
        }

        private string GetPreviousSalaryFromDatabase(string employeeName)
        {
            string previousSalary = "";
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT TOP 1 PREVIOUS_SALARY FROM [RECORDS] WHERE EMP_NAME = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("?", employeeName); // Use positional parameter
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            previousSalary = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving previous salary: " + ex.Message);
            }

            return previousSalary;
        }

        private string GetCurrentSalaryFromDatabase(string employeeName)
        {
            string currentSalary = "";
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT TOP 1 CURRENT_SALARY FROM [RECORDS] WHERE EMP_NAME = ? ORDER BY PAY_DATE DESC";
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("?", employeeName); // Use positional parameter
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            currentSalary = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving current salary: " + ex.Message);
            }

            return currentSalary;
        }

        private string[] GetEmployeesByPosition(string position)
        {
            switch (position)
            {
                case "Manager":
                    return new string[] { "Alexcis Saligao" };
                case "Sampler/Coordinator":
                    return new string[] { "Al Sinuhin", "John Paul Saligao" };
                case "Loader Operator":
                    return new string[] { "Roylan David", "Vincent Mongoc" };
                case "Engineer":
                    return new string[] { "Nelson Macarilay" };
                case "Secretary":
                    return new string[] { "Analiza Bautista", "Lorie Bautista" };
                case "Maintenance":
                    return new string[] { "Alberto Macaraig", "Dindo Maulion", "Darious Macalindong" };
                case "Truck Driver Helpers":
                    return new string[] { "Christian Indicio" };
                case "Driver":
                    return new string[] { "Marlon Bautista", "Manolo Bolea", "Michael Buendia", "Angelo Iloso", "Fernando Gonzalvo" };
                case "Operator":
                    return new string[] { "Camille Grace Sanchez" };
                default:
                    return new string[] { };
            }
        }


        private void SaveDataToDatabase()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            if (string.IsNullOrEmpty(Convert.ToString(row.Cells["EMP_ID"].Value)))
                            {
                                // Insert new record into the database
                                string insertQuery = "INSERT INTO RECORDS ([EMP_NAME], [POSITION], [RATE], [PREVIOUS_SALARY], [CURRENT_SALARY]) " +
                                                     "VALUES (@empName, @position, @rate, @previousSalary, @currentSalary)";
                                using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, connection))
                                {
                                    insertCmd.Parameters.AddWithValue("@empName", row.Cells["NAME"].Value.ToString());
                                    insertCmd.Parameters.AddWithValue("@position", row.Cells["POSITION"].Value.ToString());
                                    insertCmd.Parameters.AddWithValue("@rate", Convert.ToInt32(row.Cells["RATE"].Value));
                                    insertCmd.Parameters.AddWithValue("@previousSalary", row.Cells["PREVIOUS_SALARY"].Value.ToString());
                                    insertCmd.Parameters.AddWithValue("@currentSalary", row.Cells["CURRENT_SALARY"].Value.ToString());

                                    insertCmd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // Update existing record in the database
                                int empId = Convert.ToInt32(row.Cells["EMP_ID"].Value);
                                string empName = row.Cells["NAME"].Value.ToString();
                                string position = row.Cells["POSITION"].Value.ToString();
                                string currentSalary = row.Cells["CURRENT_SALARY"].Value.ToString();

                                string updateQuery = "UPDATE RECORDS SET EMP_NAME = @empName, [POSITION] = @position, " +
                      "CURRENT_SALARY = @currentSalary WHERE EMP_ID = @empId";
                                using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, connection))
                                {
                                    updateCmd.Parameters.AddWithValue("@empName", empName);
                                    updateCmd.Parameters.AddWithValue("@position", position);
                                    updateCmd.Parameters.AddWithValue("@currentSalary", currentSalary);
                                    updateCmd.Parameters.AddWithValue("@empId", empId);

                                    updateCmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    MessageBox.Show("Data saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm menuForm = new MainForm(loggedInUserId);
            menuForm.Show();
            this.Hide();
        }

        private void update_Click(object sender, EventArgs e)
        {
            SaveDataToDatabase();
        }

        private void add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("", "", "", "", "", "", "");
            MessageBox.Show("New row added."); 
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int empId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["EMP_ID"].Value);

                try
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM RECORDS WHERE EMP_ID = @empId";
                        using (OleDbCommand deleteCmd = new OleDbCommand(deleteQuery, connection))
                        {
                            deleteCmd.Parameters.AddWithValue("@empId", empId);
                            deleteCmd.ExecuteNonQuery();
                        }

                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    }

                    MessageBox.Show("Record deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
