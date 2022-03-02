namespace refeições
{
    partial class refeicoes
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
            this.cboPrato = new System.Windows.Forms.ComboBox();
            this.lblPrato = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboPrato
            // 
            this.cboPrato.FormattingEnabled = true;
            this.cboPrato.Items.AddRange(new object[] {
            "Vegetariano",
            "Peixe",
            "Frango",
            "Carne"});
            this.cboPrato.Location = new System.Drawing.Point(24, 91);
            this.cboPrato.Name = "cboPrato";
            this.cboPrato.Size = new System.Drawing.Size(160, 28);
            this.cboPrato.TabIndex = 0;
            this.cboPrato.SelectedIndexChanged += new System.EventHandler(this.cboPrato_SelectedIndexChanged);
            // 
            // lblPrato
            // 
            this.lblPrato.AutoSize = true;
            this.lblPrato.Location = new System.Drawing.Point(24, 58);
            this.lblPrato.Name = "lblPrato";
            this.lblPrato.Size = new System.Drawing.Size(44, 20);
            this.lblPrato.TabIndex = 1;
            this.lblPrato.Text = "Prato";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 27);
            this.textBox1.TabIndex = 2;
            // 
            // refeicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPrato);
            this.Controls.Add(this.cboPrato);
            this.Name = "refeicoes";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboPrato;
        private Label lblPrato;
        private TextBox textBox1;
    }
}