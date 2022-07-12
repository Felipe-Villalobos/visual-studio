namespace Probabilidad_Costo_Viaje
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
            this.pregasolina = new System.Windows.Forms.TextBox();
            this.kmxgalon = new System.Windows.Forms.TextBox();
            this.peajexrecorrido = new System.Windows.Forms.TextBox();
            this.kmxrecorrido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CostoTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pregasolina
            // 
            this.pregasolina.Location = new System.Drawing.Point(212, 40);
            this.pregasolina.Name = "pregasolina";
            this.pregasolina.Size = new System.Drawing.Size(100, 23);
            this.pregasolina.TabIndex = 0;
            // 
            // kmxgalon
            // 
            this.kmxgalon.Location = new System.Drawing.Point(212, 82);
            this.kmxgalon.Name = "kmxgalon";
            this.kmxgalon.Size = new System.Drawing.Size(100, 23);
            this.kmxgalon.TabIndex = 1;
            // 
            // peajexrecorrido
            // 
            this.peajexrecorrido.Location = new System.Drawing.Point(212, 128);
            this.peajexrecorrido.Name = "peajexrecorrido";
            this.peajexrecorrido.Size = new System.Drawing.Size(100, 23);
            this.peajexrecorrido.TabIndex = 2;
            // 
            // kmxrecorrido
            // 
            this.kmxrecorrido.BackColor = System.Drawing.Color.White;
            this.kmxrecorrido.Location = new System.Drawing.Point(212, 175);
            this.kmxrecorrido.Name = "kmxrecorrido";
            this.kmxrecorrido.Size = new System.Drawing.Size(100, 23);
            this.kmxrecorrido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(75, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio Galon Gasolina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Consumo Km/Galón";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cant. Peajes Recorrido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cant. Km Recorrido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Costo Viaje:";
            // 
            // CostoTotal
            // 
            this.CostoTotal.AutoSize = true;
            this.CostoTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CostoTotal.Location = new System.Drawing.Point(228, 219);
            this.CostoTotal.Name = "CostoTotal";
            this.CostoTotal.Size = new System.Drawing.Size(24, 32);
            this.CostoTotal.TabIndex = 10;
            this.CostoTotal.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(496, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CostoTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kmxrecorrido);
            this.Controls.Add(this.peajexrecorrido);
            this.Controls.Add(this.kmxgalon);
            this.Controls.Add(this.pregasolina);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox pregasolina;
        private TextBox kmxgalon;
        private TextBox peajexrecorrido;
        private TextBox kmxrecorrido;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label CostoTotal;
        private Button button1;
    }
}