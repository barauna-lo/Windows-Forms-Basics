namespace prime_numbers
{
    public partial class prime_number : Form
    {
        public prime_number()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntCleanBox_Click(object sender, EventArgs e)
        {
            txtFirst.Clear();
            txtSecond.Clear();

        }

        private void bntCleanList_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
        }

        private void btnPrime_Click(object sender, EventArgs e)
        {
            int first, second, flag;
            int primeTotal = 0;
            

            first = Convert.ToInt32(txtFirst.Text);
            second = Convert.ToInt32(txtSecond.Text);

            
            for (int i = first; i <= second; i++)
                {
                    // Skip 0 and 1 as they are neither prime nor composite
                    if (i == 1 || i == 0)
                        continue;

                    // flag variable to tell if i is prime or not
                    flag = 1;

                    for (int j = 2; j <= i / 2; ++j)
                    {
                        if (i % j == 0)
                        {
                            flag = 0;
                        break;
                        }
                    }

                    if (flag == 1)
                    {
                        // flag = 1 means i is prime and flag = 0 means i is not prime
                        lstOutput.Items.Add(i.ToString());
                        primeTotal++;
                    }
            }
            lstOutput.Items.Add("\nTotal of prime number between " + first + " and " + second + " is: " + Convert.ToString(primeTotal));
        }
    }
}