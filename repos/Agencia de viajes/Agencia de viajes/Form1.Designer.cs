namespace Agencia_de_viajes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.precop = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Iva = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Conexion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Salida = new System.Windows.Forms.Label();
            this.capiva = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.Iva.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.precop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Total);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Iva);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Num1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 409);
            this.panel1.TabIndex = 0;
            // 
            // precop
            // 
            this.precop.AutoSize = true;
            this.precop.Location = new System.Drawing.Point(262, 74);
            this.precop.Name = "precop";
            this.precop.Size = new System.Drawing.Size(16, 21);
            this.precop.TabIndex = 14;
            this.precop.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Precio en pesos Colombianos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Total.Location = new System.Drawing.Point(262, 297);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(24, 32);
            this.Total.TabIndex = 11;
            this.Total.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(129, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "Total a Pagar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(186, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Impuestos";
            // 
            // Iva
            // 
            this.Iva.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Iva.Controls.Add(this.label2);
            this.Iva.Controls.Add(this.Conexion);
            this.Iva.Controls.Add(this.label3);
            this.Iva.Controls.Add(this.label6);
            this.Iva.Controls.Add(this.Salida);
            this.Iva.Controls.Add(this.capiva);
            this.Iva.Location = new System.Drawing.Point(43, 166);
            this.Iva.Name = "Iva";
            this.Iva.Size = new System.Drawing.Size(331, 114);
            this.Iva.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salida del País";
            // 
            // Conexion
            // 
            this.Conexion.AutoSize = true;
            this.Conexion.Location = new System.Drawing.Point(219, 85);
            this.Conexion.Name = "Conexion";
            this.Conexion.Size = new System.Drawing.Size(16, 21);
            this.Conexion.TabIndex = 7;
            this.Conexion.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Iva";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Comisión de Conexión";
            // 
            // Salida
            // 
            this.Salida.AutoSize = true;
            this.Salida.Location = new System.Drawing.Point(219, 11);
            this.Salida.Name = "Salida";
            this.Salida.Size = new System.Drawing.Size(16, 21);
            this.Salida.TabIndex = 4;
            this.Salida.Text = "-";
            // 
            // capiva
            // 
            this.capiva.AutoSize = true;
            this.capiva.Location = new System.Drawing.Point(219, 49);
            this.capiva.Name = "capiva";
            this.capiva.Size = new System.Drawing.Size(16, 21);
            this.capiva.TabIndex = 5;
            this.capiva.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Precio en USD";
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(240, 27);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(100, 29);
            this.Num1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 461);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Iva.ResumeLayout(false);
            this.Iva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label Total;
        private Label label9;
        private Label label8;
        private Panel Iva;
        private Label label2;
        private Label Conexion;
        private Label label3;
        private Label label6;
        private Label Salida;
        private Label capiva;
        private Label label1;
        private TextBox Num1;
        private Label precop;
        private Label label4;
    }
}