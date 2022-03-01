namespace name_list
{
    public partial class multiplication_table : Form
    {
        public multiplication_table()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntMult_Click(object sender, EventArgs e)
        {
            int i;
            int num, start, end = 0;

            num = Convert.ToInt32(txtInput.Text);
            start = Convert.ToInt32(txtStarts.Text);
            end = Convert.ToInt32(txtEnds.Text);

            for (i = start; i <= end; i++)
            {
                lstResult.Items.Add(num + " x " + i + " = " + (num * i));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
            txtEnds.Clear();
            txtStarts.Clear();
            txtInput.Clear();

        }
    }
}