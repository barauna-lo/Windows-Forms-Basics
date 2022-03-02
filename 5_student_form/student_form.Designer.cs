namespace _5_student_form
{
    partial class student_form
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
            this.bntValidar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEscola = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEscola = new System.Windows.Forms.Label();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // bntValidar
            // 
            this.bntValidar.Location = new System.Drawing.Point(178, 245);
            this.bntValidar.Name = "bntValidar";
            this.bntValidar.Size = new System.Drawing.Size(94, 34);
            this.bntValidar.TabIndex = 9;
            this.bntValidar.Text = "Validar";
            this.bntValidar.UseVisualStyleBackColor = true;
            this.bntValidar.Click += new System.EventHandler(this.bntValidar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(178, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(165, 27);
            this.txtNome.TabIndex = 7;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(20, 63);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(152, 20);
            this.lblDataNasc.TabIndex = 6;
            this.lblDataNasc.Text = "Data de Nascimento: ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 20);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // txtEscola
            // 
            this.txtEscola.Location = new System.Drawing.Point(178, 157);
            this.txtEscola.Name = "txtEscola";
            this.txtEscola.Size = new System.Drawing.Size(165, 27);
            this.txtEscola.TabIndex = 13;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(178, 93);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(165, 27);
            this.txtEndereco.TabIndex = 12;
            // 
            // lblEscola
            // 
            this.lblEscola.AutoSize = true;
            this.lblEscola.Location = new System.Drawing.Point(20, 162);
            this.lblEscola.Name = "lblEscola";
            this.lblEscola.Size = new System.Drawing.Size(54, 20);
            this.lblEscola.TabIndex = 11;
            this.lblEscola.Text = "Escola:";
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Location = new System.Drawing.Point(20, 96);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(74, 20);
            this.lblEndereço.TabIndex = 10;
            this.lblEndereço.Text = "Endereço:";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(178, 190);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(165, 27);
            this.txtSerie.TabIndex = 15;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(20, 195);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(45, 20);
            this.lblSerie.TabIndex = 14;
            this.lblSerie.Text = "Serie:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(379, 93);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(52, 27);
            this.txtN.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "n:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(178, 126);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(165, 27);
            this.txtTel.TabIndex = 19;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(20, 129);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(69, 20);
            this.lblTel.TabIndex = 18;
            this.lblTel.Text = "Telefone:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd-MM-yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(178, 61);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(165, 27);
            this.dtpDOB.TabIndex = 20;
            // 
            // student_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 301);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.txtEscola);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEscola);
            this.Controls.Add(this.lblEndereço);
            this.Controls.Add(this.bntValidar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblNome);
            this.Name = "student_form";
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.student_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bntValidar;
        private TextBox txtNome;
        private Label lblDataNasc;
        private Label lblNome;
        private TextBox txtEscola;
        private TextBox txtEndereco;
        private Label lblEscola;
        private Label lblEndereço;
        private TextBox txtSerie;
        private Label lblSerie;
        private TextBox txtN;
        private Label label1;
        private TextBox txtTel;
        private Label lblTel;
        private DateTimePicker dtpDOB;
    }
}