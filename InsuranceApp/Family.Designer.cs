namespace InsuranceApp
{
    partial class Family
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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFMRelationship = new System.Windows.Forms.TextBox();
            this.txtFMID = new System.Windows.Forms.TextBox();
            this.txtFMSurname = new System.Windows.Forms.TextBox();
            this.txtFMFirstName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnFMAdd = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFamHomeAddress = new System.Windows.Forms.TextBox();
            this.dateTimePickerFam1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFamIDPassport = new System.Windows.Forms.TextBox();
            this.comboBoxFam = new System.Windows.Forms.ComboBox();
            this.btnFamSaveNewMember = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFamEmail = new System.Windows.Forms.TextBox();
            this.txtFamContact = new System.Windows.Forms.TextBox();
            this.txtFamLastname = new System.Windows.Forms.TextBox();
            this.txtFamFirstnames = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(263, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Surname";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(57, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "FIrst Name";
            // 
            // txtFMRelationship
            // 
            this.txtFMRelationship.Location = new System.Drawing.Point(324, 97);
            this.txtFMRelationship.Name = "txtFMRelationship";
            this.txtFMRelationship.Size = new System.Drawing.Size(150, 20);
            this.txtFMRelationship.TabIndex = 3;
            // 
            // txtFMID
            // 
            this.txtFMID.Location = new System.Drawing.Point(126, 97);
            this.txtFMID.Name = "txtFMID";
            this.txtFMID.Size = new System.Drawing.Size(145, 20);
            this.txtFMID.TabIndex = 2;
            // 
            // txtFMSurname
            // 
            this.txtFMSurname.Location = new System.Drawing.Point(222, 40);
            this.txtFMSurname.Name = "txtFMSurname";
            this.txtFMSurname.Size = new System.Drawing.Size(150, 20);
            this.txtFMSurname.TabIndex = 1;
            // 
            // txtFMFirstName
            // 
            this.txtFMFirstName.Location = new System.Drawing.Point(24, 40);
            this.txtFMFirstName.Name = "txtFMFirstName";
            this.txtFMFirstName.Size = new System.Drawing.Size(145, 20);
            this.txtFMFirstName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnFMAdd);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtFMRelationship);
            this.groupBox1.Controls.Add(this.txtFMID);
            this.groupBox1.Controls.Add(this.txtFMSurname);
            this.groupBox1.Controls.Add(this.txtFMFirstName);
            this.groupBox1.Location = new System.Drawing.Point(339, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 173);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other Family Members:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyymmdd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(407, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker1.TabIndex = 68;
            this.dateTimePicker1.Value = new System.DateTime(2020, 3, 30, 0, 0, 0, 0);
            // 
            // btnFMAdd
            // 
            this.btnFMAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFMAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFMAdd.ForeColor = System.Drawing.Color.White;
            this.btnFMAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFMAdd.Location = new System.Drawing.Point(266, 123);
            this.btnFMAdd.Name = "btnFMAdd";
            this.btnFMAdd.Size = new System.Drawing.Size(103, 43);
            this.btnFMAdd.TabIndex = 10;
            this.btnFMAdd.Text = "Add Family";
            this.btnFMAdd.UseVisualStyleBackColor = true;
            this.btnFMAdd.Click += new System.EventHandler(this.btnFMAdd_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(365, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Relationship";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(149, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "ID number/ Password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(450, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Date of Birth";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(313, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 86;
            this.label9.Text = "Date of birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(479, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "Method of payment";
            // 
            // txtFamHomeAddress
            // 
            this.txtFamHomeAddress.Location = new System.Drawing.Point(406, 190);
            this.txtFamHomeAddress.Multiline = true;
            this.txtFamHomeAddress.Name = "txtFamHomeAddress";
            this.txtFamHomeAddress.Size = new System.Drawing.Size(573, 47);
            this.txtFamHomeAddress.TabIndex = 80;
            // 
            // dateTimePickerFam1
            // 
            this.dateTimePickerFam1.CustomFormat = "yyyymmdd";
            this.dateTimePickerFam1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFam1.Location = new System.Drawing.Point(406, 121);
            this.dateTimePickerFam1.Name = "dateTimePickerFam1";
            this.dateTimePickerFam1.Size = new System.Drawing.Size(160, 20);
            this.dateTimePickerFam1.TabIndex = 90;
            this.dateTimePickerFam1.Value = new System.DateTime(2020, 3, 30, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(572, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 88;
            this.label10.Text = "IdentityNumber/Passport";
            // 
            // txtFamIDPassport
            // 
            this.txtFamIDPassport.Location = new System.Drawing.Point(707, 118);
            this.txtFamIDPassport.MaxLength = 13;
            this.txtFamIDPassport.Name = "txtFamIDPassport";
            this.txtFamIDPassport.Size = new System.Drawing.Size(272, 20);
            this.txtFamIDPassport.TabIndex = 87;
            // 
            // comboBoxFam
            // 
            this.comboBoxFam.FormattingEnabled = true;
            this.comboBoxFam.Items.AddRange(new object[] {
            "Bank Stop Order",
            "Handing Money"});
            this.comboBoxFam.Location = new System.Drawing.Point(594, 254);
            this.comboBoxFam.Name = "comboBoxFam";
            this.comboBoxFam.Size = new System.Drawing.Size(186, 21);
            this.comboBoxFam.TabIndex = 85;
            this.comboBoxFam.Text = "Select your Payment Method";
            // 
            // btnFamSaveNewMember
            // 
            this.btnFamSaveNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFamSaveNewMember.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamSaveNewMember.ForeColor = System.Drawing.Color.White;
            this.btnFamSaveNewMember.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFamSaveNewMember.Location = new System.Drawing.Point(606, 294);
            this.btnFamSaveNewMember.Name = "btnFamSaveNewMember";
            this.btnFamSaveNewMember.Size = new System.Drawing.Size(105, 36);
            this.btnFamSaveNewMember.TabIndex = 83;
            this.btnFamSaveNewMember.Text = "First Save";
            this.btnFamSaveNewMember.UseVisualStyleBackColor = true;
            this.btnFamSaveNewMember.Click += new System.EventHandler(this.btnFamSaveNewMember_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(313, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Home Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(591, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Email Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(310, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Contact Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(605, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(310, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "First names";
            // 
            // txtFamEmail
            // 
            this.txtFamEmail.Location = new System.Drawing.Point(707, 151);
            this.txtFamEmail.Name = "txtFamEmail";
            this.txtFamEmail.Size = new System.Drawing.Size(272, 20);
            this.txtFamEmail.TabIndex = 72;
            // 
            // txtFamContact
            // 
            this.txtFamContact.Location = new System.Drawing.Point(406, 151);
            this.txtFamContact.MaxLength = 11;
            this.txtFamContact.Name = "txtFamContact";
            this.txtFamContact.Size = new System.Drawing.Size(186, 20);
            this.txtFamContact.TabIndex = 71;
            // 
            // txtFamLastname
            // 
            this.txtFamLastname.Location = new System.Drawing.Point(707, 88);
            this.txtFamLastname.MaxLength = 25;
            this.txtFamLastname.Name = "txtFamLastname";
            this.txtFamLastname.Size = new System.Drawing.Size(272, 20);
            this.txtFamLastname.TabIndex = 73;
            // 
            // txtFamFirstnames
            // 
            this.txtFamFirstnames.Location = new System.Drawing.Point(406, 88);
            this.txtFamFirstnames.MaxLength = 25;
            this.txtFamFirstnames.Name = "txtFamFirstnames";
            this.txtFamFirstnames.Size = new System.Drawing.Size(193, 20);
            this.txtFamFirstnames.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Call Of Ops Duty", 39.75F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(396, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(447, 55);
            this.label5.TabIndex = 76;
            this.label5.Text = "Application Form ";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(605, 515);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 23);
            this.btnBack.TabIndex = 91;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Family
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1288, 553);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFamHomeAddress);
            this.Controls.Add(this.dateTimePickerFam1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFamIDPassport);
            this.Controls.Add(this.comboBoxFam);
            this.Controls.Add(this.btnFamSaveNewMember);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFamEmail);
            this.Controls.Add(this.txtFamContact);
            this.Controls.Add(this.txtFamLastname);
            this.Controls.Add(this.txtFamFirstnames);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Family";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Family";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Family_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFMRelationship;
        private System.Windows.Forms.TextBox txtFMID;
        private System.Windows.Forms.TextBox txtFMSurname;
        private System.Windows.Forms.TextBox txtFMFirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnFMAdd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFamHomeAddress;
        private System.Windows.Forms.DateTimePicker dateTimePickerFam1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtFamIDPassport;
        private System.Windows.Forms.ComboBox comboBoxFam;
        private System.Windows.Forms.Button btnFamSaveNewMember;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFamEmail;
        private System.Windows.Forms.TextBox txtFamContact;
        private System.Windows.Forms.TextBox txtFamLastname;
        private System.Windows.Forms.TextBox txtFamFirstnames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
    }
}