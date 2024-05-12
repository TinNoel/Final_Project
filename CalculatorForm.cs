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
    public partial class CalculatorForm : Form
    {
        private int loggedInUserId;
        private OleDbConnection con;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\BOSS MIX PAYROLL.accdb";

        private string CalTotal;
        private int num1 = 0;
        private int num2 = 0;
        private string option = " ";
        private int result = 0;
        

        public CalculatorForm(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm menuForm = new MainForm(loggedInUserId);
            menuForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            option = "multiply";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            option = "divide";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            option = "minus";
            num1 = int.Parse(textBox1.Text);

            textBox1.Clear();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            option = "addition";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox1.Text);

            if (option.Equals("addition"))
                result = num1 + num2;

            else if (option.Equals("minus"))
                result = num1 - num2;

            else if (option.Equals("divide"))

                if (num2 != 0)
                    result = num1 / num2;
                else
                    MessageBox.Show("Cannot divide by zero.");

            if (option.Equals("multiply"))
                result = num1 * num2;

            textBox1.Text = result + " ";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        }
    }