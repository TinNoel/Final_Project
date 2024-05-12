namespace BOSS_MIX_PAYROLL_SYSTEM
{
    partial class CalculatorForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(30, 189);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(394, 77);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._6351909_arrow_back_backspace_delete_erase_icon;
            this.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Location = new System.Drawing.Point(257, 288);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(59, 51);
            this.clear.TabIndex = 34;
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.button13_Click);
            // 
            // addition
            // 
            this.addition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addition.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._1904677_add_addition_calculate_charge_create_icon;
            this.addition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addition.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addition.FlatAppearance.BorderSize = 0;
            this.addition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addition.Location = new System.Drawing.Point(359, 523);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(60, 59);
            this.addition.TabIndex = 33;
            this.addition.UseVisualStyleBackColor = false;
            this.addition.Click += new System.EventHandler(this.button12_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minus.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._9698536_minus_cirlce_icon;
            this.minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.minus.FlatAppearance.BorderSize = 0;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Location = new System.Drawing.Point(355, 439);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(69, 68);
            this.minus.TabIndex = 32;
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.button11_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multiply.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._657912_cricle_cross_delete_multiply_osx_icon;
            this.multiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.multiply.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.multiply.FlatAppearance.BorderSize = 0;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply.Location = new System.Drawing.Point(359, 363);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(60, 60);
            this.multiply.TabIndex = 31;
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.button10_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.divide.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources.numbers;
            this.divide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.divide.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.divide.FlatAppearance.BorderSize = 0;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Location = new System.Drawing.Point(355, 276);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(69, 74);
            this.divide.TabIndex = 30;
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.button9_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zero.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._9022607_number_circle_zero_duotone_icon;
            this.zero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.zero.FlatAppearance.BorderSize = 0;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Location = new System.Drawing.Point(151, 594);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(74, 70);
            this.zero.TabIndex = 28;
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.button7_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nine.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._9022519_number_circle_nine_duotone_icon;
            this.nine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.nine.FlatAppearance.BorderSize = 0;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Location = new System.Drawing.Point(254, 357);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(72, 73);
            this.nine.TabIndex = 27;
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.button6_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eight.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._9022557_number_circle_eight_duotone_icon;
            this.eight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.eight.FlatAppearance.BorderSize = 0;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.Location = new System.Drawing.Point(153, 357);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(73, 73);
            this.eight.TabIndex = 26;
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.button5_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seven.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._9022506_number_circle_seven_duotone_icon;
            this.seven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seven.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.seven.FlatAppearance.BorderSize = 0;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Location = new System.Drawing.Point(48, 357);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(73, 73);
            this.seven.TabIndex = 25;
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.button4_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.six.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._9022558_number_circle_six_duotone_icon;
            this.six.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.six.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.six.FlatAppearance.BorderSize = 0;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Location = new System.Drawing.Point(254, 436);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(72, 74);
            this.six.TabIndex = 24;
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.button3_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.five.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._9022704_number_circle_five_duotone_icon;
            this.five.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.five.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.five.FlatAppearance.BorderSize = 0;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Location = new System.Drawing.Point(152, 436);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(74, 74);
            this.five.TabIndex = 23;
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.button2_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equal.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources.equal;
            this.equal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.equal.FlatAppearance.BorderSize = 0;
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal.Location = new System.Drawing.Point(359, 604);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(59, 51);
            this.equal.TabIndex = 21;
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.three.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._9022549_number_circle_three_duotone_icon;
            this.three.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.three.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.three.FlatAppearance.BorderSize = 0;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Location = new System.Drawing.Point(254, 516);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(72, 72);
            this.three.TabIndex = 15;
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.two.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._9022581_number_circle_two_duotone_icon;
            this.two.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.two.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.two.FlatAppearance.BorderSize = 0;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Location = new System.Drawing.Point(153, 516);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(73, 72);
            this.two.TabIndex = 11;
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.one.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._9022580_number_circle_one_duotone_icon;
            this.one.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.one.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.one.FlatAppearance.BorderSize = 0;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Location = new System.Drawing.Point(48, 516);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(68, 72);
            this.one.TabIndex = 6;
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.four.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._9022703_number_circle_four_duotone_icon;
            this.four.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.four.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.four.FlatAppearance.BorderSize = 0;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Location = new System.Drawing.Point(48, 436);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(73, 74);
            this.four.TabIndex = 5;
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources._9004799_arrow_direction_left_back_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 660);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 36);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BOSS_MIX_PAYROLL_SYSTEM.Properties.Resources.Log_in_story__20_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 712);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 708);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.four);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CalculatorForm";
            this.Text = "CalculatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button clear;
        internal System.Windows.Forms.Button seven;
    }
}