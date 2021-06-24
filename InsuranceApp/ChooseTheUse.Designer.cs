namespace InsuranceApp
{
    partial class ChooseTheUse
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
            this.btnNewMember = new System.Windows.Forms.Button();
            this.btnExistingMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose one of the option below";
            // 
            // btnNewMember
            // 
            this.btnNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMember.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMember.ForeColor = System.Drawing.Color.White;
            this.btnNewMember.Location = new System.Drawing.Point(549, 197);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(249, 64);
            this.btnNewMember.TabIndex = 1;
            this.btnNewMember.Text = "NEW MEMBER";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // btnExistingMember
            // 
            this.btnExistingMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExistingMember.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExistingMember.ForeColor = System.Drawing.Color.White;
            this.btnExistingMember.Location = new System.Drawing.Point(549, 346);
            this.btnExistingMember.Name = "btnExistingMember";
            this.btnExistingMember.Size = new System.Drawing.Size(249, 64);
            this.btnExistingMember.TabIndex = 2;
            this.btnExistingMember.Text = "EXISTING MEMBER";
            this.btnExistingMember.UseVisualStyleBackColor = true;
            this.btnExistingMember.Click += new System.EventHandler(this.btnExistingMember_Click);
            // 
            // ChooseTheUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1288, 550);
            this.Controls.Add(this.btnExistingMember);
            this.Controls.Add(this.btnNewMember);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChooseTheUse";
            this.ShowIcon = false;
            this.Text = "ChooseTheUse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Button btnExistingMember;
    }
}