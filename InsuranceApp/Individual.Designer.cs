namespace InsuranceApp
{
    partial class Individual
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnIFSaveNewMember = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIFIDPassport = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIFHomeAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIFEmail = new System.Windows.Forms.TextBox();
            this.txtIFContact = new System.Windows.Forms.TextBox();
            this.txtIFLastname = new System.Windows.Forms.TextBox();
            this.txtIFFirstnames = new System.Windows.Forms.TextBox();
            this.btnModifyInd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Call Of Ops Duty", 39.75F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(443, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(447, 55);
            this.label7.TabIndex = 90;
            this.label7.Text = "Application Form ";
            // 
            // btnIFSaveNewMember
            // 
            this.btnIFSaveNewMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIFSaveNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIFSaveNewMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIFSaveNewMember.ForeColor = System.Drawing.Color.White;
            this.btnIFSaveNewMember.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIFSaveNewMember.Location = new System.Drawing.Point(551, 400);
            this.btnIFSaveNewMember.Name = "btnIFSaveNewMember";
            this.btnIFSaveNewMember.Size = new System.Drawing.Size(249, 90);
            this.btnIFSaveNewMember.TabIndex = 87;
            this.btnIFSaveNewMember.Text = "Save New Member";
            this.btnIFSaveNewMember.UseVisualStyleBackColor = false;
            this.btnIFSaveNewMember.Click += new System.EventHandler(this.btnIFSaveNewMember_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyymmdd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(453, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker1.TabIndex = 85;
            this.dateTimePicker1.Value = new System.DateTime(2020, 3, 30, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(624, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 84;
            this.label10.Text = "IdentityNumber/Passport";
            // 
            // txtIFIDPassport
            // 
            this.txtIFIDPassport.Location = new System.Drawing.Point(759, 160);
            this.txtIFIDPassport.MaxLength = 13;
            this.txtIFIDPassport.Name = "txtIFIDPassport";
            this.txtIFIDPassport.Size = new System.Drawing.Size(154, 20);
            this.txtIFIDPassport.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(371, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 82;
            this.label9.Text = "Date of birth";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bank Stop Order",
            "Handing Money"});
            this.comboBox1.Location = new System.Drawing.Point(593, 309);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 81;
            this.comboBox1.Text = "Select your Payment Method";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(489, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "Method of payment";
            // 
            // txtIFHomeAddress
            // 
            this.txtIFHomeAddress.Location = new System.Drawing.Point(453, 233);
            this.txtIFHomeAddress.Multiline = true;
            this.txtIFHomeAddress.Name = "txtIFHomeAddress";
            this.txtIFHomeAddress.Size = new System.Drawing.Size(460, 47);
            this.txtIFHomeAddress.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(371, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "Home Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(643, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Email Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(368, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Contact Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(657, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(368, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "First names";
            // 
            // txtIFEmail
            // 
            this.txtIFEmail.Location = new System.Drawing.Point(759, 193);
            this.txtIFEmail.Name = "txtIFEmail";
            this.txtIFEmail.Size = new System.Drawing.Size(154, 20);
            this.txtIFEmail.TabIndex = 72;
            // 
            // txtIFContact
            // 
            this.txtIFContact.Location = new System.Drawing.Point(453, 194);
            this.txtIFContact.MaxLength = 11;
            this.txtIFContact.Name = "txtIFContact";
            this.txtIFContact.Size = new System.Drawing.Size(190, 20);
            this.txtIFContact.TabIndex = 71;
            // 
            // txtIFLastname
            // 
            this.txtIFLastname.Location = new System.Drawing.Point(759, 122);
            this.txtIFLastname.MaxLength = 25;
            this.txtIFLastname.Name = "txtIFLastname";
            this.txtIFLastname.Size = new System.Drawing.Size(154, 20);
            this.txtIFLastname.TabIndex = 73;
            // 
            // txtIFFirstnames
            // 
            this.txtIFFirstnames.Location = new System.Drawing.Point(453, 123);
            this.txtIFFirstnames.MaxLength = 25;
            this.txtIFFirstnames.Name = "txtIFFirstnames";
            this.txtIFFirstnames.Size = new System.Drawing.Size(190, 20);
            this.txtIFFirstnames.TabIndex = 70;
            // 
            // btnModifyInd
            // 
            this.btnModifyInd.BackColor = System.Drawing.Color.White;
            this.btnModifyInd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyInd.Location = new System.Drawing.Point(609, 350);
            this.btnModifyInd.Name = "btnModifyInd";
            this.btnModifyInd.Size = new System.Drawing.Size(139, 34);
            this.btnModifyInd.TabIndex = 91;
            this.btnModifyInd.Text = "Modify";
            this.btnModifyInd.UseVisualStyleBackColor = false;
            this.btnModifyInd.Visible = false;
            this.btnModifyInd.Click += new System.EventHandler(this.btnModifyInd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(646, 506);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 92;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Individual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1288, 550);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnModifyInd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnIFSaveNewMember);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIFIDPassport);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIFHomeAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIFEmail);
            this.Controls.Add(this.txtIFContact);
            this.Controls.Add(this.txtIFLastname);
            this.Controls.Add(this.txtIFFirstnames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Individual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Individual";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Individual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIFSaveNewMember;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtIFIDPassport;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIFHomeAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIFEmail;
        private System.Windows.Forms.TextBox txtIFContact;
        private System.Windows.Forms.TextBox txtIFLastname;
        private System.Windows.Forms.TextBox txtIFFirstnames;
        private System.Windows.Forms.Button btnModifyInd;
        private System.Windows.Forms.Button btnBack;
    }
}