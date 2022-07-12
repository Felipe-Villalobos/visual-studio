namespace validador_de_credito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        int Ced, NumCuot;
        double MontoS;
        double interes = 14.4;
        int numerocuota = 1;


        public void CapturaNombreYcedula()
        {
            string Nom;
            string Nombre;
            Nom = Convert.ToString(CapNombre.Text);
            Nombre = Nom;

            nombre.Text = Nombre;

            int Cedula;
            Ced = Convert.ToInt32(CapCedula.Text);
            Cedula = Ced;

            cedula.Text = Cedula.ToString();
        }
        private void CalCuota_Click(object sender, EventArgs e)
        {

            CapturaNombreYcedula();

            
            int Cuot1;
            NumCuot = Convert.ToInt32(CapCuotas.Text);
            Cuot1 = NumCuot;
            NumCuotas.Text = Cuot1.ToString();

            double Montoso;
            MontoS = Convert.ToDouble(CapMonto.Text);
            Montoso = MontoS;

            msolicitado.Text = Montoso.ToString();

            tsinteres.Text = interes.ToString();

           
                double PeriodoInteres = Montoso * (interes / Cuot1) / 100;
                double MontoTotal = Montoso + PeriodoInteres;
                double abono = MontoTotal / Cuot1;
               // double abono = amortizacion - PeriodoInteres;
                double Cuota = abono + PeriodoInteres;
                   
                ValorCuota.Text =Cuota.ToString();
               
                               
                
          

           


        }

        
    }
}