namespace calcular_area_triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double alt, bas;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double area;
            bas = Convert.ToDouble(A.Text);
            alt= Convert.ToDouble(B.Text);
            area = (bas * alt) / 2;
            total.Text = area.ToString();

        }
    }
}