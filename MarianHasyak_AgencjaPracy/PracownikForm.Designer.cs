namespace MarianHasyak_AgencjaPracy
{
    partial class PracownikForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.hasEducationCheck = new System.Windows.Forms.CheckBox();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.expTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yearStartedNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.peselMasked = new System.Windows.Forms.MaskedTextBox();
            this.birthdayDateTime = new System.Windows.Forms.DateTimePicker();
            this.photoButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yearNumeric = new System.Windows.Forms.NumericUpDown();
            this.ratingNumeric = new System.Windows.Forms.NumericUpDown();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.skillsTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yearStartedNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(314, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(469, 225);
            this.listBox1.TabIndex = 54;
            // 
            // hasEducationCheck
            // 
            this.hasEducationCheck.AutoSize = true;
            this.hasEducationCheck.Location = new System.Drawing.Point(132, 336);
            this.hasEducationCheck.Name = "hasEducationCheck";
            this.hasEducationCheck.Size = new System.Drawing.Size(15, 14);
            this.hasEducationCheck.TabIndex = 15;
            this.hasEducationCheck.UseVisualStyleBackColor = true;
            // 
            // jobTextBox
            // 
            this.jobTextBox.Location = new System.Drawing.Point(85, 234);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(206, 20);
            this.jobTextBox.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Job doing:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(216, 331);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // expTextBox
            // 
            this.expTextBox.Location = new System.Drawing.Point(85, 256);
            this.expTextBox.Name = "expTextBox";
            this.expTextBox.Size = new System.Drawing.Size(206, 20);
            this.expTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Experience:";
            // 
            // yearStartedNumeric
            // 
            this.yearStartedNumeric.Location = new System.Drawing.Point(132, 308);
            this.yearStartedNumeric.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.yearStartedNumeric.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearStartedNumeric.Name = "yearStartedNumeric";
            this.yearStartedNumeric.Size = new System.Drawing.Size(159, 20);
            this.yearStartedNumeric.TabIndex = 14;
            this.yearStartedNumeric.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Year started working:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 61;
            this.label11.Text = "Has education:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(314, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 175);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // peselMasked
            // 
            this.peselMasked.Location = new System.Drawing.Point(85, 46);
            this.peselMasked.Mask = "00000000000";
            this.peselMasked.Name = "peselMasked";
            this.peselMasked.Size = new System.Drawing.Size(206, 20);
            this.peselMasked.TabIndex = 2;
            this.peselMasked.ValidatingType = typeof(int);
            this.peselMasked.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.peselMasked_MaskInputRejected);
            // 
            // birthdayDateTime
            // 
            this.birthdayDateTime.CustomFormat = "dd/MM";
            this.birthdayDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayDateTime.Location = new System.Drawing.Point(85, 95);
            this.birthdayDateTime.Name = "birthdayDateTime";
            this.birthdayDateTime.Size = new System.Drawing.Size(206, 20);
            this.birthdayDateTime.TabIndex = 4;
            // 
            // photoButton
            // 
            this.photoButton.Location = new System.Drawing.Point(85, 15);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(207, 24);
            this.photoButton.TabIndex = 1;
            this.photoButton.UseVisualStyleBackColor = true;
            this.photoButton.Click += new System.EventHandler(this.photoButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Photo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "Birthday:";
            // 
            // yearNumeric
            // 
            this.yearNumeric.Location = new System.Drawing.Point(85, 72);
            this.yearNumeric.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.yearNumeric.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearNumeric.Name = "yearNumeric";
            this.yearNumeric.Size = new System.Drawing.Size(206, 20);
            this.yearNumeric.TabIndex = 3;
            this.yearNumeric.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // ratingNumeric
            // 
            this.ratingNumeric.Location = new System.Drawing.Point(85, 208);
            this.ratingNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ratingNumeric.Name = "ratingNumeric";
            this.ratingNumeric.Size = new System.Drawing.Size(206, 20);
            this.ratingNumeric.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(85, 185);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(206, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(191, 162);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.countryTextBox.TabIndex = 8;
            this.countryTextBox.Text = "Contry";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(85, 162);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 7;
            this.cityTextBox.Text = "City";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(85, 139);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(206, 20);
            this.surnameTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(85, 117);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(206, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "Rating:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "E-mail:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Location:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Surname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 73;
            this.label12.Text = "Year born:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 72;
            this.label13.Text = "Pesel:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // skillsTextBox
            // 
            this.skillsTextBox.Location = new System.Drawing.Point(85, 282);
            this.skillsTextBox.Name = "skillsTextBox";
            this.skillsTextBox.Size = new System.Drawing.Size(206, 20);
            this.skillsTextBox.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 91;
            this.label14.Text = "Skills:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(217, 415);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 23);
            this.btnFill.TabIndex = 17;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // PracownikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.skillsTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.peselMasked);
            this.Controls.Add(this.birthdayDateTime);
            this.Controls.Add(this.photoButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yearNumeric);
            this.Controls.Add(this.ratingNumeric);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.yearStartedNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.expTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.hasEducationCheck);
            this.Controls.Add(this.jobTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAdd);
            this.Name = "PracownikForm";
            this.Text = "PracownikForm";
            ((System.ComponentModel.ISupportInitialize)(this.yearStartedNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox hasEducationCheck;
        private System.Windows.Forms.TextBox jobTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox expTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown yearStartedNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MaskedTextBox peselMasked;
        private System.Windows.Forms.DateTimePicker birthdayDateTime;
        private System.Windows.Forms.Button photoButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown yearNumeric;
        private System.Windows.Forms.NumericUpDown ratingNumeric;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox skillsTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnFill;
    }
}