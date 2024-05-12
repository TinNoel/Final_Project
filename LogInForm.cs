using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BOSS_MIX_PAYROLL_SYSTEM
{
    public partial class LogInForm : Form
    {

        private int loggedInUserId;
        private OleDbConnection con;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\BOSS MIX PAYROLL.accdb";

        public LogInForm()
        {
            InitializeComponent();

            con = new OleDbConnection(connectionString);
            password.PasswordChar = '*';
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            int maxLoginAttempts = 3;
            int failedLoginAttempts = 0;

            loggedInUserId = GetUserIdFromDatabase(email.Text, password.Text);

            try
            {
                // Open the connection before using it
                con.Open();

                using (OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM AdminTable WHERE [email] = @email AND [password] = @password", con))
                {
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@password", password.Text);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        this.Hide();
                        MainForm homePage = new MainForm(loggedInUserId);
                        homePage.Show();
                    }
                    else
                    {
                        failedLoginAttempts++;

                        if (failedLoginAttempts >= maxLoginAttempts)
                        {
                            MessageBox.Show("Account locked. Too many unsuccessful login attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // You may want to take additional actions here like locking the account in the database
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection after using it
                con.Close();
            }
        }

        private int GetUserIdFromDatabase(string email, string password)
        {
            int userId = 0;

            try
            {
                // Open the connection before using it
                con.Open();

                using (OleDbCommand cmd = new OleDbCommand("SELECT admin_id FROM AdminTable WHERE [email] = @email AND [password] = @password", con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        userId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching admin ID from database: " + ex.Message);
            }
            finally
            {
                
                con.Close();
            }

            return userId;
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = showpass.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUpForm signupForm = new SignUpForm();
            signupForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

}