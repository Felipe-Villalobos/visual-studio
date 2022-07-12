namespace conversión_de_divisas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        double Num1,Num2;

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double conversion;
            Num1 = Convert.ToDouble(num1.Text);
            Num2 = Convert.ToDouble(num2.Text);
            conversion = Num2 * Num1;

            total.Text = conversion.ToString();

        }
    }
}