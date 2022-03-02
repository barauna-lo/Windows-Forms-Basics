namespace user
{
    partial class user
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblKg = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblPrato = new System.Windows.Forms.Label();
            this.cblPrato = new System.Windows.Forms.ComboBox();
            this.txtCalPrato = new System.Windows.Forms.TextBox();
            this.lblCaloria = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalSobremesa = new System.Windows.Forms.TextBox();
            this.cblSobremesa = new System.Windows.Forms.ComboBox();
            this.lblSobremesa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalBebida = new System.Windows.Forms.TextBox();
            this.cblBebida = new System.Windows.Forms.ComboBox();
            this.lblBebida = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdPrato = new System.Windows.Forms.TextBox();
            this.txtQtdSobremesa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtdBebida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalCal = new System.Windows.Forms.TextBox();
            this.lblTotalCal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(29, 357);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(114, 60);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular Total de Calorias";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "CADASTRAR USUÁRIO";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(23, 95);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 92);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(198, 27);
            this.txtNome.TabIndex = 3;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(344, 95);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(50, 27);
            this.txtIdade.TabIndex = 5;
            this.txtIdade.TextChanged += new System.EventHandler(this.txtIdade_TextChanged);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(285, 98);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(50, 20);
            this.lblIdade.TabIndex = 4;
            this.lblIdade.Text = "Idade:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(457, 95);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(51, 27);
            this.txtAltura.TabIndex = 7;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(399, 98);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(52, 20);
            this.lblAltura.TabIndex = 6;
            this.lblAltura.Text = "Altura:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(595, 95);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(51, 27);
            this.txtPeso.TabIndex = 9;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(547, 98);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(42, 20);
            this.lblPeso.TabIndex = 8;
            this.lblPeso.Text = "Peso:";
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(652, 102);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(27, 20);
            this.lblKg.TabIndex = 10;
            this.lblKg.Text = "Kg";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(514, 102);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(22, 20);
            this.lblM.TabIndex = 11;
            this.lblM.Text = "m";
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(729, 95);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(51, 27);
            this.txtIMC.TabIndex = 13;
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Location = new System.Drawing.Point(685, 98);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(38, 20);
            this.lblIMC.TabIndex = 12;
            this.lblIMC.Text = "IMC:";
            // 
            // lblPrato
            // 
            this.lblPrato.AutoSize = true;
            this.lblPrato.Location = new System.Drawing.Point(23, 153);
            this.lblPrato.Name = "lblPrato";
            this.lblPrato.Size = new System.Drawing.Size(44, 20);
            this.lblPrato.TabIndex = 14;
            this.lblPrato.Text = "Prato";
            // 
            // cblPrato
            // 
            this.cblPrato.FormattingEnabled = true;
            this.cblPrato.Items.AddRange(new object[] {
            "Vegetariano",
            "Peixe",
            "Frango",
            "Carne"});
            this.cblPrato.Location = new System.Drawing.Point(28, 182);
            this.cblPrato.Name = "cblPrato";
            this.cblPrato.Size = new System.Drawing.Size(186, 28);
            this.cblPrato.TabIndex = 15;
            this.cblPrato.SelectedIndexChanged += new System.EventHandler(this.cblPrato_SelectedIndexChanged);
            // 
            // txtCalPrato
            // 
            this.txtCalPrato.Location = new System.Drawing.Point(122, 213);
            this.txtCalPrato.Name = "txtCalPrato";
            this.txtCalPrato.Size = new System.Drawing.Size(92, 27);
            this.txtCalPrato.TabIndex = 16;
            this.txtCalPrato.TextChanged += new System.EventHandler(this.txtCalPrato_TextChanged);
            // 
            // lblCaloria
            // 
            this.lblCaloria.AutoSize = true;
            this.lblCaloria.Location = new System.Drawing.Point(220, 220);
            this.lblCaloria.Name = "lblCaloria";
            this.lblCaloria.Size = new System.Drawing.Size(30, 20);
            this.lblCaloria.TabIndex = 17;
            this.lblCaloria.Text = "Cal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cal";
            // 
            // txtCalSobremesa
            // 
            this.txtCalSobremesa.Location = new System.Drawing.Point(416, 213);
            this.txtCalSobremesa.Name = "txtCalSobremesa";
            this.txtCalSobremesa.Size = new System.Drawing.Size(92, 27);
            this.txtCalSobremesa.TabIndex = 20;
            this.txtCalSobremesa.TextChanged += new System.EventHandler(this.txtCalSobremesa_TextChanged);
            // 
            // cblSobremesa
            // 
            this.cblSobremesa.FormattingEnabled = true;
            this.cblSobremesa.Items.AddRange(new object[] {
            "Abacaxi",
            "Sorvete diet",
            "Mouse diet",
            "Moouse Choc"});
            this.cblSobremesa.Location = new System.Drawing.Point(321, 182);
            this.cblSobremesa.Name = "cblSobremesa";
            this.cblSobremesa.Size = new System.Drawing.Size(187, 28);
            this.cblSobremesa.TabIndex = 19;
            this.cblSobremesa.SelectedIndexChanged += new System.EventHandler(this.cblSobremesa_SelectedIndexChanged);
            // 
            // lblSobremesa
            // 
            this.lblSobremesa.AutoSize = true;
            this.lblSobremesa.Location = new System.Drawing.Point(316, 153);
            this.lblSobremesa.Name = "lblSobremesa";
            this.lblSobremesa.Size = new System.Drawing.Size(83, 20);
            this.lblSobremesa.TabIndex = 18;
            this.lblSobremesa.Text = "Sobremesa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(805, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cal";
            // 
            // txtCalBebida
            // 
            this.txtCalBebida.Location = new System.Drawing.Point(707, 213);
            this.txtCalBebida.Name = "txtCalBebida";
            this.txtCalBebida.Size = new System.Drawing.Size(92, 27);
            this.txtCalBebida.TabIndex = 24;
            this.txtCalBebida.TextChanged += new System.EventHandler(this.txtCalBebida_TextChanged);
            // 
            // cblBebida
            // 
            this.cblBebida.FormattingEnabled = true;
            this.cblBebida.Items.AddRange(new object[] {
            "Chá",
            "Suco de Laranja",
            "Suco de Melão",
            "Refri diet"});
            this.cblBebida.Location = new System.Drawing.Point(614, 182);
            this.cblBebida.Name = "cblBebida";
            this.cblBebida.Size = new System.Drawing.Size(185, 28);
            this.cblBebida.TabIndex = 23;
            this.cblBebida.SelectedIndexChanged += new System.EventHandler(this.cblBebida_SelectedIndexChanged);
            // 
            // lblBebida
            // 
            this.lblBebida.AutoSize = true;
            this.lblBebida.Location = new System.Drawing.Point(609, 153);
            this.lblBebida.Name = "lblBebida";
            this.lblBebida.Size = new System.Drawing.Size(56, 20);
            this.lblBebida.TabIndex = 22;
            this.lblBebida.Text = "Bebida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Qtd";
            // 
            // txtQtdPrato
            // 
            this.txtQtdPrato.Location = new System.Drawing.Point(68, 213);
            this.txtQtdPrato.Name = "txtQtdPrato";
            this.txtQtdPrato.Size = new System.Drawing.Size(38, 27);
            this.txtQtdPrato.TabIndex = 28;
            // 
            // txtQtdSobremesa
            // 
            this.txtQtdSobremesa.Location = new System.Drawing.Point(361, 213);
            this.txtQtdSobremesa.Name = "txtQtdSobremesa";
            this.txtQtdSobremesa.Size = new System.Drawing.Size(38, 27);
            this.txtQtdSobremesa.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Qtd";
            // 
            // txtQtdBebida
            // 
            this.txtQtdBebida.Location = new System.Drawing.Point(654, 213);
            this.txtQtdBebida.Name = "txtQtdBebida";
            this.txtQtdBebida.Size = new System.Drawing.Size(38, 27);
            this.txtQtdBebida.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(614, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Qtd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Cal";
            // 
            // txtTotalCal
            // 
            this.txtTotalCal.Location = new System.Drawing.Point(149, 299);
            this.txtTotalCal.Name = "txtTotalCal";
            this.txtTotalCal.Size = new System.Drawing.Size(92, 27);
            this.txtTotalCal.TabIndex = 34;
            this.txtTotalCal.TextChanged += new System.EventHandler(this.txtTotalCal_TextChanged);
            // 
            // lblTotalCal
            // 
            this.lblTotalCal.AutoSize = true;
            this.lblTotalCal.Location = new System.Drawing.Point(23, 299);
            this.lblTotalCal.Name = "lblTotalCal";
            this.lblTotalCal.Size = new System.Drawing.Size(120, 20);
            this.lblTotalCal.TabIndex = 35;
            this.lblTotalCal.Text = "Total de Calorias";
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 439);
            this.Controls.Add(this.lblTotalCal);
            this.Controls.Add(this.txtTotalCal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQtdBebida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQtdSobremesa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQtdPrato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCalBebida);
            this.Controls.Add(this.cblBebida);
            this.Controls.Add(this.lblBebida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCalSobremesa);
            this.Controls.Add(this.cblSobremesa);
            this.Controls.Add(this.lblSobremesa);
            this.Controls.Add(this.lblCaloria);
            this.Controls.Add(this.txtCalPrato);
            this.Controls.Add(this.cblPrato);
            this.Controls.Add(this.lblPrato);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "user";
            this.Text = "Cadastrar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcular;
        private Label label1;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtIdade;
        private Label lblIdade;
        private TextBox txtAltura;
        private Label lblAltura;
        private TextBox txtPeso;
        private Label lblPeso;
        private Label lblKg;
        private Label lblM;
        private TextBox txtIMC;
        private Label lblIMC;
        private Label lblPrato;
        private ComboBox cblPrato;
        private TextBox txtCalPrato;
        private Label lblCaloria;
        private Label label2;
        private TextBox txtCalSobremesa;
        private ComboBox cblSobremesa;
        private Label lblSobremesa;
        private Label label4;
        private TextBox txtCalBebida;
        private ComboBox cblBebida;
        private Label lblBebida;
        private Label label3;
        private TextBox txtQtdPrato;
        private TextBox txtQtdSobremesa;
        private Label label5;
        private TextBox txtQtdBebida;
        private Label label6;
        private Label label7;
        private TextBox txtTotalCal;
        private Label lblTotalCal;
    }
}