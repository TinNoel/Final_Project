namespace BOSS_MIX_PAYROLL_SYSTEM
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TaxChart = new System.Windows.Forms.Button();
            this.Notes = new System.Windows.Forms.Button();
            this.Calculator = new System.Windows.Forms.Button();
            this.Records = new System.Windows.Forms.Button();
            this.PayslipCalcu = new System.Windows.Forms.Button();
            this.Signout = new System.Windows.Forms.Button();
            this.MENUPICTUREBOX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MENUPICTUREBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Payroll Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee Records";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Keep Notes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Calculator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Deductions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 576);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sign Out";
            // 
            // TaxChart
            // 
            this.TaxChart.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._5027881_business_chart_finance_graph_money_icon;
            this.TaxChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TaxChart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TaxChart.Location = new System.Drawing.Point(106, 468);
            this.TaxChart.Name = "TaxChart";
            this.TaxChart.Size = new System.Drawing.Size(110, 105);
            this.TaxChart.TabIndex = 6;
            this.TaxChart.UseVisualStyleBackColor = true;
            this.TaxChart.Click += new System.EventHandler(this.TaxChart_Click);
            // 
            // Notes
            // 
            this.Notes.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._6012901_diagnosis_document_medical_paper_records_icon;
            this.Notes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Notes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Notes.Location = new System.Drawing.Point(106, 326);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(110, 105);
            this.Notes.TabIndex = 5;
            this.Notes.UseVisualStyleBackColor = true;
            this.Notes.Click += new System.EventHandler(this.Notes_Click);
            // 
            // Calculator
            // 
            this.Calculator.BackColor = System.Drawing.Color.White;
            this.Calculator.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._8168681_calculator_math_accounting_finance_icon;
            this.Calculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Calculator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Calculator.Location = new System.Drawing.Point(287, 326);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(110, 105);
            this.Calculator.TabIndex = 4;
            this.Calculator.UseVisualStyleBackColor = false;
            this.Calculator.Click += new System.EventHandler(this.button4_Click);
            // 
            // Records
            // 
            this.Records.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._5027838_dollar_management_money_icon;
            this.Records.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Records.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Records.Location = new System.Drawing.Point(287, 187);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(110, 105);
            this.Records.TabIndex = 3;
            this.Records.UseVisualStyleBackColor = true;
            this.Records.Click += new System.EventHandler(this.Records_Click);
            // 
            // PayslipCalcu
            // 
            this.PayslipCalcu.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._7000034_halloween_schedule_calendar_event_time_icon;
            this.PayslipCalcu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PayslipCalcu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PayslipCalcu.Location = new System.Drawing.Point(106, 187);
            this.PayslipCalcu.Name = "PayslipCalcu";
            this.PayslipCalcu.Size = new System.Drawing.Size(110, 105);
            this.PayslipCalcu.TabIndex = 2;
            this.PayslipCalcu.UseVisualStyleBackColor = true;
            this.PayslipCalcu.Click += new System.EventHandler(this.button2_Click);
            // 
            // Signout
            // 
            this.Signout.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._1608410_out_sign_icon;
            this.Signout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Signout.Location = new System.Drawing.Point(287, 468);
            this.Signout.Name = "Signout";
            this.Signout.Size = new System.Drawing.Size(110, 105);
            this.Signout.TabIndex = 1;
            this.Signout.UseVisualStyleBackColor = true;
            this.Signout.Click += new System.EventHandler(this.button1_Click);
            // 
            // MENUPICTUREBOX
            // 
            this.MENUPICTUREBOX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MENUPICTUREBOX.Image = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources.Log_in_story__4_;
            this.MENUPICTUREBOX.Location = new System.Drawing.Point(-2, -2);
            this.MENUPICTUREBOX.Name = "MENUPICTUREBOX";
            this.MENUPICTUREBOX.Size = new System.Drawing.Size(478, 709);
            this.MENUPICTUREBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MENUPICTUREBOX.TabIndex = 0;
            this.MENUPICTUREBOX.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 708);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TaxChart);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.Calculator);
            this.Controls.Add(this.Records);
            this.Controls.Add(this.PayslipCalcu);
            this.Controls.Add(this.Signout);
            this.Controls.Add(this.MENUPICTUREBOX);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MENUPICTUREBOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MENUPICTUREBOX;
        private System.Windows.Forms.Button Signout;
        private System.Windows.Forms.Button PayslipCalcu;
        private System.Windows.Forms.Button Records;
        private System.Windows.Forms.Button Calculator;
        private System.Windows.Forms.Button Notes;
        private System.Windows.Forms.Button TaxChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}