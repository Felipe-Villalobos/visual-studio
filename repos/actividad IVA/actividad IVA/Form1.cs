namespace actividad_IVA
{
    public partial class Calculos : Form
    {
        public Calculos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        double Num1;
        private void iva_Click(object sender, EventArgs e)
        {
            double iva;
            Num1 = Convert.ToDouble(monto.Text);
            iva = Num1 * 0.19;
            MessageBox.Show("El Iva es: " + iva);
        }

        private void comision_Click(object sender, EventArgs e)
        {
            double comision;
            Num1 = Convert.ToDouble(monto.Text);
            comision = Num1 * 0.10;
            MessageBox.Show("La comisión es: "+ comision);
        }
    }
}