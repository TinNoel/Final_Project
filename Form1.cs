using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.Versioning;

namespace BOSS_MIX_PAYROLL_SYSTEM
{
    public partial class Workspace : Form
    {
      
        public Workspace()
        {
            InitializeComponent();

          

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            LogInForm loginForm = new LogInForm();
            loginForm.Show();
            this.Hide();
        }

        private void Workspace_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
