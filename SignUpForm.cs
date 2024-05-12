using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BOSS_MIX_PAYROLL_SYSTEM
{
    public partial class SignUpForm : Form
    {
        // Connection string for your Access database
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\BOSS MIX PAYROLL.accdb;Persist Security Info=False;";

        public SignUpForm()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

        private void login_Click(object sender, EventArgs e)
        {
            LogInForm loginForm = new LogInForm();
            loginForm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }


        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string firstName = firstname.Text;
            string lastName = lastname.Text;
            string userEmail = email.Text;
            string userPassword = password.Text;

            // Validate user input
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
               string.IsNullOrWhiteSpace(userEmail) || string.IsNullOrWhiteSpace(userPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        // Check connection state
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open(); // Open the connection if it's not already open
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error opening connection: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Return from the method if connection opening fails
                    }

                    // Proceed with the database operation
                    string query = "INSERT INTO AdminTable ([fname], [lname], [email], [password]) VALUES (@fname, @lname, @email, @password)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fname", firstName);
                        command.Parameters.AddWithValue("@lname", lastName);
                        command.Parameters.AddWithValue("@email", userEmail);
                        command.Parameters.AddWithValue("@password", userPassword);

                        int rowsAffected = command.ExecuteNonQuery();

                        // Handle the result of the operation
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LogInForm loginForm = new LogInForm();
                            loginForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Sign up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}