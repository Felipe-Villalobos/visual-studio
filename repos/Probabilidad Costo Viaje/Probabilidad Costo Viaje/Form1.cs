namespace Probabilidad_Costo_Viaje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Pregasolina, KmxGalon, Cpeajes, KmRecorrido, peaje = 11000;
        
        private void button1_Click(object sender, EventArgs e)
        {
            int Total, Totalpeajes, kmtotal, totalcombustible;
            Pregasolina = Convert.ToInt32(pregasolina.Text);
            KmxGalon = Convert.ToInt32(kmxgalon.Text);
            Cpeajes = Convert.ToInt32(peajexrecorrido.Text);
            KmRecorrido = Convert.ToInt32(kmxrecorrido.Text);
            Totalpeajes = peaje * Cpeajes;
            kmtotal = KmRecorrido / KmxGalon;
            totalcombustible = kmtotal * Pregasolina;
            Total = totalcombustible + Totalpeajes;

            CostoTotal.Text = Total.ToString();

        }
    }
}