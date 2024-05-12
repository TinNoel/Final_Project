using System;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BOSS_MIX_PAYROLL_SYSTEM
{
    public partial class KeepNotes : Form
    {
        private int loggedInUserId;
        private OleDbConnection con;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\BOSS MIX PAYROLL.accdb";

        public KeepNotes(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
            con = new OleDbConnection(connectionString);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (var con = new OleDbConnection(connectionString))
            {
                con.Open();
                var checkQuery = "SELECT COUNT(*) FROM Notes WHERE title = ? AND datecreated = ? AND admin_id = ?";
                using (var checkCmd = new OleDbCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("?", Title.Text);
                    checkCmd.Parameters.AddWithValue("?", dateTimePicker1.Value.Date);
                    checkCmd.Parameters.AddWithValue("?", loggedInUserId);
                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("A note with the same title and date already exists for this account.");
                        return; // Prevent insertion of duplicate
                    }
                }

                // Proceed with insertion if no duplicates found
                var insertQuery = "INSERT INTO Notes (admin_id, title, datecreated, notes) VALUES (?, ?, ?, ?)";
                using (var cmd = new OleDbCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("?", loggedInUserId);
                    cmd.Parameters.AddWithValue("?", Title.Text);
                    cmd.Parameters.AddWithValue("?", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("?", notes.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Note saved successfully.");
                }
            }
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new OleDbConnection(connectionString))
                {
                    con.Open();
                    var query = "DELETE FROM Notes WHERE title = ? AND admin_id = ?";
                    using (var cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("?", Title.Text);
                        cmd.Parameters.AddWithValue("?", loggedInUserId);
                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show(result > 0 ? "Note deleted successfully." : "No note found to delete.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete the note. Error: " + ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new OleDbConnection(connectionString))
                {
                    con.Open();
                    var query = "UPDATE Notes SET notes = ?, datecreated = ? WHERE title = ? AND admin_id = ?";
                    using (var cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("?", notes.Text);
                        cmd.Parameters.AddWithValue("?", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("?", Title.Text);
                        cmd.Parameters.AddWithValue("?", loggedInUserId);
                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show(result > 0 ? "Note updated successfully." : "No note found to update.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update the note. Error: " + ex.Message);
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new OleDbConnection(connectionString))
                {
                    con.Open();
                    var query = "DELETE FROM Notes WHERE title = ? AND admin_id = ?";
                    using (var cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("?", Title.Text);
                        cmd.Parameters.AddWithValue("?", loggedInUserId);
                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show(result > 0 ? "Note deleted successfully." : "No note found to delete.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete the note. Error: " + ex.Message);
            }
        }
        private void Title_TextChanged(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void notes_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            MainForm menuForm = new MainForm(loggedInUserId);
            menuForm.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {

        }
    }
}
