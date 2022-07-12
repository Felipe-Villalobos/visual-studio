namespace actividad_IVA
{
    partial class Calculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculos));
            this.label1 = new System.Windows.Forms.Label();
            this.monto = new System.Windows.Forms.TextBox();
            this.iva = new System.Windows.Forms.Button();
            this.comision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(90, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el monto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(115, 44);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(100, 23);
            this.monto.TabIndex = 1;
            // 
            // iva
            // 
            this.iva.Location = new System.Drawing.Point(31, 190);
            this.iva.Name = "iva";
            this.iva.Size = new System.Drawing.Size(85, 41);
            this.iva.TabIndex = 2;
            this.iva.Text = "Calcular IVA 19%";
            this.iva.UseVisualStyleBackColor = true;
            this.iva.Click += new System.EventHandler(this.iva_Click);
            // 
            // comision
            // 
            this.comision.Location = new System.Drawing.Point(212, 190);
            this.comision.Name = "comision";
            this.comision.Size = new System.Drawing.Size(82, 41);
            this.comision.TabIndex = 3;
            this.comision.Text = "Calcular Comision";
            this.comision.UseVisualStyleBackColor = true;
            this.comision.Click += new System.EventHandler(this.comision_Click);
            // 
            // Calculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(352, 295);
            this.Controls.Add(this.comision);
            this.Controls.Add(this.iva);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Calculos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox monto;
        private Button iva;
        private Button comision;
    }
}