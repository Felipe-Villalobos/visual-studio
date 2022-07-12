namespace promedio_notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            int N1, N2, N3, N4, N5, N6, nota, promedio;
            N1 = Convert.ToInt32(n1.Text);
            N2 = Convert.ToInt32(n2.Text);
            N3 = Convert.ToInt32(n3.Text);
            N4 = Convert.ToInt32(n4.Text);
            N5 = Convert.ToInt32(n5.Text);
            N6 = Convert.ToInt32(n6.Text);

            nota= N1+N2+ N3 + N4 + N5 + N6;
            promedio = nota / 6;
            NotaFinal.Text = promedio.ToString();


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}