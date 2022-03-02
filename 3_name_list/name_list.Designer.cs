namespace name_list
{
    partial class name_list
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstNameOutput = new System.Windows.Forms.ListBox();
            this.bntCleanList = new System.Windows.Forms.Button();
            this.bntCleanNameBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Insert a name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 27);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save into list";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstNameOutput
            // 
            this.lstNameOutput.FormattingEnabled = true;
            this.lstNameOutput.ItemHeight = 20;
            this.lstNameOutput.Location = new System.Drawing.Point(209, 31);
            this.lstNameOutput.Name = "lstNameOutput";
            this.lstNameOutput.Size = new System.Drawing.Size(128, 244);
            this.lstNameOutput.TabIndex = 6;
            // 
            // bntCleanList
            // 
            this.bntCleanList.Location = new System.Drawing.Point(12, 220);
            this.bntCleanList.Name = "bntCleanList";
            this.bntCleanList.Size = new System.Drawing.Size(168, 35);
            this.bntCleanList.TabIndex = 7;
            this.bntCleanList.Text = "Clean all item";
            this.bntCleanList.UseVisualStyleBackColor = true;
            this.bntCleanList.Click += new System.EventHandler(this.bntReset_Click);
            // 
            // bntCleanNameBox
            // 
            this.bntCleanNameBox.Location = new System.Drawing.Point(12, 179);
            this.bntCleanNameBox.Name = "bntCleanNameBox";
            this.bntCleanNameBox.Size = new System.Drawing.Size(168, 35);
            this.bntCleanNameBox.TabIndex = 8;
            this.bntCleanNameBox.Text = "Clean Name Box";
            this.bntCleanNameBox.UseVisualStyleBackColor = true;
            this.bntCleanNameBox.Click += new System.EventHandler(this.bntCleanNameBox_Click);
            // 
            // name_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 300);
            this.Controls.Add(this.bntCleanNameBox);
            this.Controls.Add(this.bntCleanList);
            this.Controls.Add(this.lstNameOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Name = "name_list";
            this.Text = "Name List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button btnSave;
        private ListBox lstNameOutput;
        private Button bntCleanList;
        private Button bntCleanNameBox;
    }
}