namespace BOSS_MIX_PAYROLL_SYSTEM
{
    partial class PAYROLL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RegularEmployee = new System.Windows.Forms.RadioButton();
            this.Trainee = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.overtime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.loan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bonus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DEDUCTIONS = new System.Windows.Forms.CheckBox();
            this.calculate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.name.Location = new System.Drawing.Point(46, 194);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(177, 26);
            this.name.TabIndex = 4;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(46, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(264, 275);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(267, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Position:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RegularEmployee
            // 
            this.RegularEmployee.AutoSize = true;
            this.RegularEmployee.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.RegularEmployee.Location = new System.Drawing.Point(46, 248);
            this.RegularEmployee.Name = "RegularEmployee";
            this.RegularEmployee.Size = new System.Drawing.Size(164, 24);
            this.RegularEmployee.TabIndex = 9;
            this.RegularEmployee.TabStop = true;
            this.RegularEmployee.Text = "Regular Employee";
            this.RegularEmployee.UseVisualStyleBackColor = false;
            this.RegularEmployee.CheckedChanged += new System.EventHandler(this.RegularEmployee_CheckedChanged);
            // 
            // Trainee
            // 
            this.Trainee.AutoSize = true;
            this.Trainee.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Trainee.Location = new System.Drawing.Point(46, 290);
            this.Trainee.Name = "Trainee";
            this.Trainee.Size = new System.Drawing.Size(162, 24);
            this.Trainee.TabIndex = 10;
            this.Trainee.TabStop = true;
            this.Trainee.Text = "Trainee / Part time";
            this.Trainee.UseVisualStyleBackColor = false;
            this.Trainee.CheckedChanged += new System.EventHandler(this.Trainee_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimePicker1.Location = new System.Drawing.Point(262, 194);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 26);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(267, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pay date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(46, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Working days:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(44, 370);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 26);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(46, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Overtime:";
            // 
            // overtime
            // 
            this.overtime.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.overtime.Location = new System.Drawing.Point(44, 435);
            this.overtime.Name = "overtime";
            this.overtime.Size = new System.Drawing.Size(177, 26);
            this.overtime.TabIndex = 19;
            this.overtime.TextChanged += new System.EventHandler(this.overtime_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(278, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Loan:";
            // 
            // loan
            // 
            this.loan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.loan.Location = new System.Drawing.Point(262, 370);
            this.loan.Name = "loan";
            this.loan.Size = new System.Drawing.Size(177, 26);
            this.loan.TabIndex = 21;
            this.loan.TextChanged += new System.EventHandler(this.loan_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(46, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Bonus";
            // 
            // bonus
            // 
            this.bonus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bonus.Location = new System.Drawing.Point(44, 505);
            this.bonus.Name = "bonus";
            this.bonus.Size = new System.Drawing.Size(177, 26);
            this.bonus.TabIndex = 27;
            this.bonus.TextChanged += new System.EventHandler(this.bonus_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(258, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Would you like to calculate";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(259, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "deductions?";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // DEDUCTIONS
            // 
            this.DEDUCTIONS.AutoSize = true;
            this.DEDUCTIONS.Location = new System.Drawing.Point(238, 438);
            this.DEDUCTIONS.Name = "DEDUCTIONS";
            this.DEDUCTIONS.Size = new System.Drawing.Size(22, 21);
            this.DEDUCTIONS.TabIndex = 31;
            this.DEDUCTIONS.UseVisualStyleBackColor = true;
            this.DEDUCTIONS.CheckedChanged += new System.EventHandler(this.DEDUCTIONS_CheckedChanged);
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.calculate.Location = new System.Drawing.Point(271, 493);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(130, 51);
            this.calculate.TabIndex = 17;
            this.calculate.Text = "PRINT";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._9004799_arrow_direction_left_back_icon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(12, 608);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 35);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources.Log_in_story__20_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 655);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PAYROLL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 655);
            this.Controls.Add(this.DEDUCTIONS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bonus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.loan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.overtime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Trainee);
            this.Controls.Add(this.RegularEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PAYROLL";
            this.Text = "PAYROLL";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RegularEmployee;
        private System.Windows.Forms.RadioButton Trainee;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox overtime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox loan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bonus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox DEDUCTIONS;
    }
}