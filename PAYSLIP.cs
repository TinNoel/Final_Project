using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BOSS_MIX_PAYROLL_SYSTEM
{
    public partial class PAYSLIP : Form
    {
        public PAYSLIP(string name, string position, string type, double rate, double hoursWorked, double overtimeHours, double bonus, double sss, double philHealth, double loan, double totalDeductions, double netSalary)
        {
            InitializeComponent();

            NAME.Text = name;
            POSITION.Text = position;
            TYPE.Text = type;
            RATE.Text = rate.ToString("C");
            HOURS.Text = hoursWorked.ToString();
            OVERTIME.Text = overtimeHours.ToString();
            BONUS.Text = bonus.ToString("C");
            SSS.Text = sss.ToString("C");
            PHILHEALTH.Text = philHealth.ToString("C");
            LOAN.Text = loan.ToString("C");

            double grossPay = (rate * hoursWorked) + (overtimeHours * rate * 1.5) + bonus;

            GROSSPAY.Text = grossPay.ToString("C");


            TOTALDEDUCTIONS.Text = totalDeductions.ToString("C");
            NETSALARY.Text = netSalary.ToString("C");
        }

        private void PAYSLIP_Load(object sender, EventArgs e)
        {

        }

        private void DATE_Click(object sender, EventArgs e)
        {

        }

        private void TYPE_Click(object sender, EventArgs e)
        {

        }

        private void HOURS_Click(object sender, EventArgs e)
        {

        }

        private void POSITION_Click(object sender, EventArgs e)
        {

        }

        private void NAME_Click(object sender, EventArgs e)
        {

        }

        private void RATE_Click(object sender, EventArgs e)
        {

        }

        private void OVERTIME_Click(object sender, EventArgs e)
        {

        }

        private void BONUS_Click(object sender, EventArgs e)
        {

        }

        private void SSS_Click(object sender, EventArgs e)
        {

        }

        private void PHILHEALTH_Click(object sender, EventArgs e)
        {

        }

        private void LOAN_Click(object sender, EventArgs e)
        {

        }

        private void TOTALDEDUCTIONS_Click(object sender, EventArgs e)
        {

        }

        private void NETSALARY_Click(object sender, EventArgs e)
        {

        }

        private void GROSSPAY_Click(object sender, EventArgs e)
        {

        }
    }
}
