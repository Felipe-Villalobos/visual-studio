namespace FERRETERIA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cambio = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Subtotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.CapEfecRecib = new System.Windows.Forms.TextBox();
            this.CapCantidad = new System.Windows.Forms.TextBox();
            this.CapPrecio = new System.Windows.Forms.TextBox();
            this.CapProducto = new System.Windows.Forms.TextBox();
            this.CapCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.iva = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvlista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cambio);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.Subtotal);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.Eliminar);
            this.panel1.Controls.Add(this.Agregar);
            this.panel1.Controls.Add(this.Total);
            this.panel1.Controls.Add(this.CapEfecRecib);
            this.panel1.Controls.Add(this.CapCantidad);
            this.panel1.Controls.Add(this.CapPrecio);
            this.panel1.Controls.Add(this.CapProducto);
            this.panel1.Controls.Add(this.CapCodigo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.iva);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvlista);
            this.panel1.Location = new System.Drawing.Point(33, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 430);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cambio
            // 
            this.cambio.AutoSize = true;
            this.cambio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cambio.Location = new System.Drawing.Point(313, 376);
            this.cambio.Name = "cambio";
            this.cambio.Size = new System.Drawing.Size(0, 15);
            this.cambio.TabIndex = 22;
            this.cambio.Click += new System.EventHandler(this.cambio_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(203, 376);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 15);
            this.label15.TabIndex = 21;
            this.label15.Text = "Cambio:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Subtotal.Location = new System.Drawing.Point(313, 290);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(0, 15);
            this.Subtotal.TabIndex = 18;
            this.Subtotal.Click += new System.EventHandler(this.Subtotal_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(204, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Subtotal";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(285, 71);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(98, 46);
            this.Eliminar.TabIndex = 16;
            this.Eliminar.Text = "ELIMINAR";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(285, 14);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(98, 46);
            this.Agregar.TabIndex = 15;
            this.Agregar.Text = "AGREGAR";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Total.Location = new System.Drawing.Point(301, 343);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(0, 28);
            this.Total.TabIndex = 14;
            this.Total.Click += new System.EventHandler(this.label9_Click);
            // 
            // CapEfecRecib
            // 
            this.CapEfecRecib.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CapEfecRecib.Location = new System.Drawing.Point(49, 358);
            this.CapEfecRecib.Name = "CapEfecRecib";
            this.CapEfecRecib.Size = new System.Drawing.Size(100, 23);
            this.CapEfecRecib.TabIndex = 13;
            this.CapEfecRecib.TextChanged += new System.EventHandler(this.CapEfecRecib_TextChanged);
            this.CapEfecRecib.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CapEfecRecib_KeyPress);
            // 
            // CapCantidad
            // 
            this.CapCantidad.Location = new System.Drawing.Point(133, 96);
            this.CapCantidad.Name = "CapCantidad";
            this.CapCantidad.Size = new System.Drawing.Size(100, 23);
            this.CapCantidad.TabIndex = 12;
            this.CapCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CapCantidad_KeyPress);
            // 
            // CapPrecio
            // 
            this.CapPrecio.Location = new System.Drawing.Point(133, 65);
            this.CapPrecio.Name = "CapPrecio";
            this.CapPrecio.Size = new System.Drawing.Size(100, 23);
            this.CapPrecio.TabIndex = 11;
            this.CapPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CapPrecio_KeyPress);
            this.CapPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.CapPrecio_Validating);
            this.CapPrecio.Validated += new System.EventHandler(this.CapPrecio_Validated);
            // 
            // CapProducto
            // 
            this.CapProducto.Location = new System.Drawing.Point(133, 37);
            this.CapProducto.Name = "CapProducto";
            this.CapProducto.Size = new System.Drawing.Size(100, 23);
            this.CapProducto.TabIndex = 10;
            this.CapProducto.Validated += new System.EventHandler(this.CapProducto_Validated);
            // 
            // CapCodigo
            // 
            this.CapCodigo.Location = new System.Drawing.Point(133, 8);
            this.CapCodigo.Name = "CapCodigo";
            this.CapCodigo.Size = new System.Drawing.Size(100, 23);
            this.CapCodigo.TabIndex = 9;
            this.CapCodigo.TextChanged += new System.EventHandler(this.CapCodigo_TextChanged);
            this.CapCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.CapCodigo_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(49, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Efectivo Recibido";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(204, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Iva 19%";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // iva
            // 
            this.iva.AutoSize = true;
            this.iva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iva.Location = new System.Drawing.Point(313, 316);
            this.iva.Name = "iva";
            this.iva.Size = new System.Drawing.Size(0, 15);
            this.iva.TabIndex = 6;
            this.iva.Click += new System.EventHandler(this.iva_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(199, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "CANTIDAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "PRECIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "PRODUCTO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "CODIGO";
            // 
            // dgvlista
            // 
            this.dgvlista.AllowUserToAddRows = false;
            this.dgvlista.AllowUserToDeleteRows = false;
            this.dgvlista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvlista.Location = new System.Drawing.Point(15, 125);
            this.dgvlista.Name = "dgvlista";
            this.dgvlista.ReadOnly = true;
            this.dgvlista.RowHeadersVisible = false;
            this.dgvlista.RowTemplate.Height = 25;
            this.dgvlista.Size = new System.Drawing.Size(410, 146);
            this.dgvlista.TabIndex = 0;
            this.dgvlista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlista_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CODIGO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PRODUCTO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PRECIO";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CANTIDAD";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TOTAL";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FERRETERIA.Properties.Resources.IO__2_;
            this.ClientSize = new System.Drawing.Size(507, 547);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label Total;
        private TextBox CapEfecRecib;
        private TextBox CapCantidad;
        private TextBox CapPrecio;
        private TextBox CapProducto;
        private TextBox CapCodigo;
        private Label label7;
        private Label iva;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvlista;
        private Button Eliminar;
        private Button Agregar;
        private Label Subtotal;
        private Label label11;
        private Label cambio;
        private Label label15;
        private Label label8;
        private Label label5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private ErrorProvider epError;
    }
}