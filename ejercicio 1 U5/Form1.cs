namespace ejercicio_1_U5
{
    public partial class Form1 : Form
    {
        string[] names = new string[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string[] enterednames = txtname.Text.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < Math.Min(enterednames.Length, 5); i++)
            {
                names[i] = enterednames[i];
            }

        }

        
        private void btnsave_Click(object sender, EventArgs e)
        {
            string[] enterednames = txtname.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (enterednames.Length != 5)
            {
                MessageBox.Show("Please enter exactly 5 names separated by spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Array.Copy(enterednames, names, 5);
           
            txtnames.Text = string.Join(", ", names);
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double[,] values = new double[2, 1];


            if (double.TryParse(txtsalary.Text, out values[0, 0]) && double.TryParse(txthours.Text, out values[1, 0]))
            {

                double resultado = values[0, 0] * values[1, 0];


                txttotal.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in both text boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}