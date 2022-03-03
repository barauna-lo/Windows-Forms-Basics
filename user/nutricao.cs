namespace user
{
    public partial class nutricao : Form
    {
        public nutricao()
        {
            InitializeComponent();
        }

        private void bntIMC_Click(object sender, EventArgs e)
        {
           
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            double peso, altura, imc;

            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);

            if (altura != 0)
            {
                imc = peso / Math.Pow(altura, 2);
                txtIMC.Text = String.Format("{0:0.00}", imc);
            }
            else
            {
                MessageBox.Show("Verificar Campo Altura");
            }
        }

        private void cblPrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            String prato;

            //Calorias Prato
            if (String.IsNullOrEmpty(cblPrato.Text))
            {
                txtQtdPrato.Text = "0";
            }
            else
            {
                prato = Convert.ToString(cblPrato.Text);

                if (prato == "Vegetariano")
                {
                    txtCalPrato.Text = String.Format("{0:0.}", 180);

                    int idade, peso2;
                    idade = Convert.ToInt32(txtIdade.Text);
                    peso2 = Convert.ToInt32(txtPeso.Text);

                    if (idade < 18 && peso2 < 75)
                    {
                        MessageBox.Show("Opção Vegetariano não permitida, escolha outro item.");
                    }
                }
                if (prato == "Peixe")
                {
                    txtCalPrato.Text = String.Format("{0:0.}", 230);
                }
                if (prato == "Frango")
                {
                    txtCalPrato.Text = String.Format("{0:0.}", 250);
                }
                if (prato == "Carne")
                {
                    txtCalPrato.Text = String.Format("{0:0.}", 350);

                    int idade, peso2;
                    idade = Convert.ToInt32(txtIdade.Text);
                    peso2 = Convert.ToInt32(txtPeso.Text);

                    if (idade < 18 && peso2 > 75)
                    {
                        MessageBox.Show("Opção Carne não permitida, escolha outro item.");
                    }
                }

            }
        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalCal_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtCalPrato_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCalBebida_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCalSobremesa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int qtdPrato, qtdSobremesa, qtdBebida, calPrato, calSobremesa, calBebida, totalCalorias;


            if (String.IsNullOrEmpty(txtQtdSobremesa.Text) || String.IsNullOrEmpty(txtQtdSobremesa.Text) || String.IsNullOrEmpty(txtQtdPrato.Text))
            {
                MessageBox.Show("inserir quantidades");
            }
            else
            {
                qtdPrato = Convert.ToInt32(txtQtdPrato.Text);
                calPrato = Convert.ToInt32(txtCalPrato.Text);
                qtdSobremesa = Convert.ToInt32(txtQtdSobremesa.Text);
                calSobremesa = Convert.ToInt32(txtCalSobremesa.Text);
                qtdBebida = Convert.ToInt32(txtQtdBebida.Text);
                calBebida = Convert.ToInt32(txtCalBebida.Text);
                totalCalorias = qtdPrato * calPrato + qtdSobremesa * calSobremesa + qtdBebida * calBebida;
                txtTotalCal.Text = String.Format("{0:0.00}", totalCalorias);

                if(totalCalorias > 600)
                {
                    MessageBox.Show("Quantidade de Calorias Elevada");
                }
            }
        }

        private void cblSobremesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sobremesa;

            if (String.IsNullOrEmpty(cblSobremesa.Text))
            {
                txtQtdSobremesa.Text = "0";
                
            }
            else
            {
                sobremesa = Convert.ToString(cblSobremesa.Text);

                if (sobremesa == "Abacaxi")
                {
                    txtCalSobremesa.Text = String.Format("{0:0.}", 75);
                }
                if (sobremesa == "Sorvete diet")
                {
                    txtCalSobremesa.Text = String.Format("{0:0.}", 110);
                }
                if (sobremesa == "Mouse diet")
                {
                    txtCalSobremesa.Text = String.Format("{0:0.}", 170);
                }
                if (sobremesa == "Mouse Choc")
                {
                    txtCalSobremesa.Text = String.Format("{0:0.}", 200);
                }
            }

            
        }

        private void cblBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            String bebida;

            //Calorias bebida
            if (String.IsNullOrEmpty(cblBebida.Text))
            {
                txtQtdBebida.Text = "0";
            }
            else
            {
                bebida = Convert.ToString(cblBebida.Text);

                if (bebida == "Chá")
                {
                    txtCalBebida.Text = String.Format("{0:0.}", 20);
                }
                if (bebida == "Suco de Laranja")
                {
                    txtCalBebida.Text = String.Format("{0:0.}", 70);
                }
                if (bebida == "Suco de Melão")
                {
                    txtCalBebida.Text = String.Format("{0:0.}", 100);
                }
                if (bebida == "Refri diet")
                {
                    txtCalBebida.Text = String.Format("{0:0.}", 65);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtPeso.Clear();
            txtAltura.Clear();
            txtIMC.Clear();

            
            txtQtdPrato.Clear();    
            //txtCalPrato.Clear();

            txtQtdSobremesa.Clear();
            txtCalSobremesa.Clear();

            txtQtdBebida.Clear();
            //txtCalBebida.Clear();

            txtQtdSobremesa.Clear();
           // txtTotalCal.Clear();

        }
    }
}