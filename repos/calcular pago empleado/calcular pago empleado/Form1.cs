namespace calcular_pago_empleado
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
        double Valor;
        private void button1_Click(object sender, EventArgs e)
        {
            double salud,pension,total;
            Valor = Convert.ToDouble(valor.Text);
            salud = Valor / 100 * 4;
            pension = Valor / 100 * 4;
            total = Valor - salud - pension;

            Salud.Text = salud.ToString();
            Pension.Text = pension.ToString();
            Total.Text = total.ToString();
        }
    }
}