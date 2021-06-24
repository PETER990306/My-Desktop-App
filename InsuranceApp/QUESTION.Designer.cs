namespace InsuranceApp
{
    partial class QUESTION
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
            this.btnFamily = new System.Windows.Forms.Button();
            this.btnIndividual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFamily
            // 
            this.btnFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFamily.ForeColor = System.Drawing.Color.White;
            this.btnFamily.Location = new System.Drawing.Point(585, 374);
            this.btnFamily.Name = "btnFamily";
            this.btnFamily.Size = new System.Drawing.Size(159, 44);
            this.btnFamily.TabIndex = 5;
            this.btnFamily.Text = "Family";
            this.btnFamily.UseVisualStyleBackColor = true;
            this.btnFamily.Click += new System.EventHandler(this.btnFamily_Click);
            // 
            // btnIndividual
            // 
            this.btnIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndividual.ForeColor = System.Drawing.Color.White;
            this.btnIndividual.Location = new System.Drawing.Point(585, 256);
            this.btnIndividual.Name = "btnIndividual";
            this.btnIndividual.Size = new System.Drawing.Size(159, 44);
            this.btnIndividual.TabIndex = 4;
            this.btnIndividual.Text = "Individual";
            this.btnIndividual.UseVisualStyleBackColor = true;
            this.btnIndividual.Click += new System.EventHandler(this.btnIndividual_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(440, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Which Policy are you making?";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(625, 449);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 31);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // QUESTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1288, 539);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFamily);
            this.Controls.Add(this.btnIndividual);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QUESTION";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUESTION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFamily;
        private System.Windows.Forms.Button btnIndividual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}