namespace Agencia_de_viajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double tscambio = 3983.00;
        double salida, iva, conexion, USD, total;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double COP;
            USD = Convert.ToDouble(Num1.Text);
            COP = USD * tscambio;
            iva = COP / 100 * 19;
            salida = COP / 100 * 10;
            conexion = COP / 100 * 5;
            total = (COP + iva + salida + conexion);
            precop.Text = COP.ToString();

            if (COP >= 2500000)
            {
               
                Salida.Text = salida.ToString();
                capiva.Text = iva.ToString();
                Conexion.Text = conexion.ToString();
                Total.Text = total.ToString();

            } else
                {

                salida = 0;
                iva = 0;
                conexion = 0;
                Salida.Text = salida.ToString();
                capiva.Text = iva.ToString();
                Conexion.Text = conexion.ToString();
                Total.Text = COP.ToString();



            }
        }
    }
}