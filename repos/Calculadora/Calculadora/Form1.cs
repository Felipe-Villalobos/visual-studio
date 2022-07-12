namespace Calculadora
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

        double Num1, Num2;
        private void button1_Click(object sender, EventArgs e)
        {
            double suma;
            Num1 = Convert.ToDouble(num1.Text);
            Num2 = Convert.ToDouble(num2.Text);
            suma = Num1 + Num2;
            MessageBox.Show("El resultado de la suma es "+ suma);

        }
             
        private void multiplicar_Click_1(object sender, EventArgs e)
        {
            double multiplica;
            Num1 = Convert.ToDouble(num1.Text);
            Num2 = Convert.ToDouble(num2.Text);
            multiplica = Num1 * Num2;
            MessageBox.Show("El resultado de la Multiplicación es " + multiplica);
        }

        private void resta_Click_1(object sender, EventArgs e)
        {
            double resta;
            Num1 = Convert.ToDouble(num1.Text);
            Num2 = Convert.ToDouble(num2.Text);
            resta = Num1 - Num2;
            MessageBox.Show("El resultado de la resta es " + resta);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void division_Click(object sender, EventArgs e)
        {
            double dividir;
            Num1 = Convert.ToDouble(num1.Text);
            Num2 = Convert.ToDouble(num2.Text);
            dividir = Num1 / Num2;
            MessageBox.Show("El resultado de la división es " + dividir);
        }

        
    }
}