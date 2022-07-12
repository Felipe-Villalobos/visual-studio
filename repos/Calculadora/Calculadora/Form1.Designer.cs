namespace Calculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(247, 30);
            this.num1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 21);
            this.num1.TabIndex = 2;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(247, 64);
            this.num2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 21);
            this.num2.TabIndex = 3;
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(21, 165);
            this.suma.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(75, 24);
            this.suma.TabIndex = 4;
            this.suma.Text = "Suma";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.button1_Click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(154, 165);
            this.resta.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(75, 24);
            this.resta.TabIndex = 5;
            this.resta.Text = "Resta";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click_1);
            // 
            // multiplicar
            // 
            this.multiplicar.Location = new System.Drawing.Point(282, 165);
            this.multiplicar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(102, 24);
            this.multiplicar.TabIndex = 6;
            this.multiplicar.Text = "Multiplicación";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click_1);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(415, 165);
            this.division.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 24);
            this.division.TabIndex = 7;
            this.division.Text = "División";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(514, 388);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox num1;
        private TextBox num2;
        private Button suma;
        private Button resta;
        private Button multiplicar;
        private Button division;
    }
}