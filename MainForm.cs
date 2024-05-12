using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BOSS_MIX_PAYROLL_SYSTEM
{
    public partial class MainForm : Form
    {
       
        private int loggedInUserId;
        private OleDbConnection con;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\BOSS MIX PAYROLL.accdb";


        public MainForm(int userId)
        {
            InitializeComponent();
            con = new OleDbConnection(connectionString);
            loggedInUserId = userId;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PAYROLL payForm = new PAYROLL(loggedInUserId);
            payForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void Notes_Click(object sender, EventArgs e)
        {
            KeepNotes notesForm = new KeepNotes(loggedInUserId);
            notesForm.Show();
            this.Hide();
        }

        private void Records_Click(object sender, EventArgs e)
        {
            EmployeeRecord recordForm = new EmployeeRecord(loggedInUserId);
            recordForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalculatorForm calcuForm = new CalculatorForm(loggedInUserId);
            calcuForm.Show();
            this.Hide();
        }

        private void TaxChart_Click(object sender, EventArgs e)
        {
            Deductions deductionsForm = new Deductions(0);
            deductionsForm.Show();
            this.Hide();
        }
    }
}