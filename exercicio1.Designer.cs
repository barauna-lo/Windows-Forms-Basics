namespace Windows_Forms_Basics
{
    partial class exercicio1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassaword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.bntLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(40, 62);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email: ";
            // 
            // lblPassaword
            // 
            this.lblPassaword.AutoSize = true;
            this.lblPassaword.Location = new System.Drawing.Point(40, 97);
            this.lblPassaword.Name = "lblPassaword";
            this.lblPassaword.Size = new System.Drawing.Size(73, 20);
            this.lblPassaword.TabIndex = 1;
            this.lblPassaword.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 59);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 27);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(119, 94);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(165, 27);
            this.txtPassword.TabIndex = 3;
            // 
            // bntLogin
            // 
            this.bntLogin.Location = new System.Drawing.Point(133, 154);
            this.bntLogin.Name = "bntLogin";
            this.bntLogin.Size = new System.Drawing.Size(94, 34);
            this.bntLogin.TabIndex = 4;
            this.bntLogin.Text = "Login";
            this.bntLogin.UseVisualStyleBackColor = true;
            this.bntLogin.Click += new System.EventHandler(this.bntLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 261);
            this.Controls.Add(this.bntLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassaword);
            this.Controls.Add(this.lblEmail);
            this.Name = "Form1";
            this.Text = "Email Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEmail;
        private Label lblPassaword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button bntLogin;
    }
}