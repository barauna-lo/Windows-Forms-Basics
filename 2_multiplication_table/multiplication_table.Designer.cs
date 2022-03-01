namespace name_list
{
    partial class multiplication_table
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
            this.bntMult = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.bntReset = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtStarts = new System.Windows.Forms.TextBox();
            this.txtEnds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bntMult
            // 
            this.bntMult.Location = new System.Drawing.Point(55, 228);
            this.bntMult.Name = "bntMult";
            this.bntMult.Size = new System.Drawing.Size(94, 29);
            this.bntMult.TabIndex = 0;
            this.bntMult.Text = "Multiply";
            this.bntMult.UseVisualStyleBackColor = true;
            this.bntMult.Click += new System.EventHandler(this.bntMult_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(55, 56);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(115, 20);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Insert a number:";
            this.lblInput.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Result:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(176, 53);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(65, 27);
            this.txtInput.TabIndex = 4;
            // 
            // bntReset
            // 
            this.bntReset.Location = new System.Drawing.Point(176, 226);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(89, 31);
            this.bntReset.TabIndex = 5;
            this.bntReset.Text = "Reset";
            this.bntReset.UseVisualStyleBackColor = true;
            this.bntReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(55, 96);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(66, 20);
            this.lblStart.TabIndex = 6;
            this.lblStart.Text = "Starts at:";
            // 
            // txtStarts
            // 
            this.txtStarts.Location = new System.Drawing.Point(176, 96);
            this.txtStarts.Name = "txtStarts";
            this.txtStarts.Size = new System.Drawing.Size(65, 27);
            this.txtStarts.TabIndex = 7;
            // 
            // txtEnds
            // 
            this.txtEnds.Location = new System.Drawing.Point(176, 140);
            this.txtEnds.Name = "txtEnds";
            this.txtEnds.Size = new System.Drawing.Size(65, 27);
            this.txtEnds.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ends at:";
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 20;
            this.lstResult.Location = new System.Drawing.Point(315, 53);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(133, 204);
            this.lstResult.TabIndex = 10;
            // 
            // multiplication_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 275);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnds);
            this.Controls.Add(this.txtStarts);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.bntReset);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.bntMult);
            this.Name = "multiplication_table";
            this.Text = "Multiplication Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bntMult;
        private Label lblInput;
        private Label label2;
        private TextBox txtInput;
        private Button bntReset;
        private Label lblStart;
        private TextBox txtStarts;
        private TextBox txtEnds;
        private Label label1;
        private ListBox lstResult;
    }
}