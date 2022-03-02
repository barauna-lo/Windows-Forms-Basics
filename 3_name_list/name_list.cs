namespace name_list
{
    public partial class name_list : Form
    {
        public name_list()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name;

            name = txtName.Text;

            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("name box is empty!");
            }
            else
            {
                lstNameOutput.Items.Add(name);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            lstNameOutput.Items.Clear();
        }

        private void bntCleanNameBox_Click(object sender, EventArgs e)
        {
            txtName.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}