namespace _5_student_form
{
    public partial class student_form : Form
    {
        public student_form()
        {
            InitializeComponent();
        }

        private void bntValidar_Click(object sender, EventArgs e)
        {
            String name, address, school;
            int n, serie, phone;
            DateTime date;

            name = Convert.ToString(txtNome.Text);
            date = Convert.ToDateTime(dtpDOB.Value);
            address = Convert.ToString(txtEndereco.Text);
            phone = Convert.ToInt32(txtTel.Text);
            school = Convert.ToString(txtEscola.Text);
            serie = Convert.ToInt32(txtSerie.Text);
            address = Convert.ToString(txtEndereco.Text);
            n = Convert.ToInt32(txtN.Text);



           //falta definir condições para checar se os inputs estão vazios

        }

        private void student_form_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}