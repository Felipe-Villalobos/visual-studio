namespace FERRETERIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        double CapPre, CapCant;

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvlista.Rows.Remove(dgvlista.CurrentRow);
            }
            catch { }
            obsubtotal();
            iva19();
            costTot();
        }

        private void Subtotal_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                double total;
                CapPre = Convert.ToDouble(CapPrecio.Text);
                CapCant = Convert.ToDouble(CapCantidad.Text);
                total = CapPre * CapCant;



                DataGridViewRow file = new DataGridViewRow();
                file.CreateCells(dgvlista);

                file.Cells[0].Value = CapCodigo.Text;
                file.Cells[1].Value = CapProducto.Text;
                file.Cells[2].Value = CapPrecio.Text;
                file.Cells[3].Value = CapCantidad.Text;
                file.Cells[4].Value = total;


                dgvlista.Rows.Add(file);


                CapCodigo.Text = "";
                CapProducto.Text = "";
                CapPrecio.Text = "";
                CapCantidad.Text = "";
                CapEfecRecib.Text = "";
                cambio.Text = "";
            }
            catch { }

            obsubtotal();

            iva19();

            costTot();
            



        }
        
       

        public void costTot()
        {
            
            int suma = 0;
            double subtotal = 0;
            double iva1 = 0;
            double  total = 0;


            suma = dgvlista.Rows.Count;

            for (int i = 0; i < dgvlista.Rows.Count; i++)
            {
                subtotal += Convert.ToInt32(dgvlista.Rows[i].Cells[4].Value);
                iva1 += Convert.ToInt32(dgvlista.Rows[i].Cells[4].Value) * 0.19;
                total = subtotal + iva1;


            }
            Total.Text = total.ToString();                

        }


        public void iva19()
        {
            int suma2 = 0;
            double iva19 = 0;

            suma2 = dgvlista.Rows.Count;

            for (int i = 0; i < dgvlista.Rows.Count; i++)
            {
                iva19 += Convert.ToInt32(dgvlista.Rows[i].Cells[4].Value) * 0.19;

            }
            iva.Text = iva19.ToString();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void cambio_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void iva_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CapEfecRecib_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cambio.Text = (int.Parse(CapEfecRecib.Text) - int.Parse(Total.Text)  ).ToString();
            }
            catch { }
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CapEfecRecib_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se puede insertar numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void CapCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se puede insertar numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void CapPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se puede insertar numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void CapCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void CapCodigo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(CapCodigo.Text.Trim() == "")
            {
                epError.SetError(CapCodigo, "Introdusca Codigo de Producto");
                CapCodigo.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void CapProducto_Validated(object sender, EventArgs e)
        {
            if (CapProducto.Text.Trim() == "")
            {
                epError.SetError(CapProducto, "Introdusca Codigo de Producto");
                CapProducto.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void CapPrecio_Validated(object sender, EventArgs e)
        {
            if (CapCodigo.Text.Trim() == "")
            {
                epError.SetError(CapCodigo, "Introdusca Codigo de Producto");
                CapCodigo.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void CapPrecio_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (CapPrecio.Text.Trim() == "")
            {
                epError.SetError(CapPrecio, "Introdusca Precio de Producto");
                CapPrecio.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        public void obsubtotal()
        {
            int costSub = 0;
            int suma = 0;
          

            suma = dgvlista.Rows.Count;

            for (int i = 0; i < dgvlista.Rows.Count; i++)
            {
                costSub += Convert.ToInt32(dgvlista.Rows[i].Cells[4].Value) ;

            }
            Subtotal.Text = costSub.ToString();
            
         }

                    
        private void dgvlista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}