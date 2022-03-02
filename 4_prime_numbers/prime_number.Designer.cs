namespace prime_numbers
{
    partial class prime_number
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
            this.bntCleanBox = new System.Windows.Forms.Button();
            this.bntCleanList = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.btnPrime = new System.Windows.Forms.Button();
            this.lblSecond = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntCleanBox
            // 
            this.bntCleanBox.Location = new System.Drawing.Point(14, 217);
            this.bntCleanBox.Name = "bntCleanBox";
            this.bntCleanBox.Size = new System.Drawing.Size(168, 35);
            this.bntCleanBox.TabIndex = 14;
            this.bntCleanBox.Text = "Clean Boxes";
            this.bntCleanBox.UseVisualStyleBackColor = true;
            this.bntCleanBox.Click += new System.EventHandler(this.bntCleanBox_Click);
            // 
            // bntCleanList
            // 
            this.bntCleanList.Location = new System.Drawing.Point(14, 258);
            this.bntCleanList.Name = "bntCleanList";
            this.bntCleanList.Size = new System.Drawing.Size(168, 35);
            this.bntCleanList.TabIndex = 13;
            this.bntCleanList.Text = "Clean all item";
            this.bntCleanList.UseVisualStyleBackColor = true;
            this.bntCleanList.Click += new System.EventHandler(this.bntCleanList_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 20;
            this.lstOutput.Location = new System.Drawing.Point(211, 23);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(363, 264);
            this.lstOutput.TabIndex = 12;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(14, 23);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(132, 20);
            this.lblInput.TabIndex = 11;
            this.lblInput.Text = "Insert first number:";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(14, 46);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(168, 27);
            this.txtFirst.TabIndex = 10;
            // 
            // btnPrime
            // 
            this.btnPrime.Location = new System.Drawing.Point(14, 176);
            this.btnPrime.Name = "btnPrime";
            this.btnPrime.Size = new System.Drawing.Size(168, 35);
            this.btnPrime.TabIndex = 9;
            this.btnPrime.Text = "Prime";
            this.btnPrime.UseVisualStyleBackColor = true;
            this.btnPrime.Click += new System.EventHandler(this.btnPrime_Click);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(14, 91);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(154, 20);
            this.lblSecond.TabIndex = 16;
            this.lblSecond.Text = "Insert second number:";
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(14, 114);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(168, 27);
            this.txtSecond.TabIndex = 15;
            // 
            // prime_number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 314);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.bntCleanBox);
            this.Controls.Add(this.bntCleanList);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.btnPrime);
            this.Name = "prime_number";
            this.Text = "prime number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bntCleanBox;
        private Button bntCleanList;
        private ListBox lstOutput;
        private Label lblInput;
        private TextBox txtFirst;
        private Button btnPrime;
        private Label lblSecond;
        private TextBox txtSecond;
    }
}