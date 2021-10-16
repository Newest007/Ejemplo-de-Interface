
namespace Ejemplo_de_Interface
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtincognita1 = new System.Windows.Forms.TextBox();
            this.btnARectangulo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtincognita2 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnATringulo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnACuadrado = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejemplo de Interfaces en C#";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtincognita1
            // 
            this.txtincognita1.Location = new System.Drawing.Point(322, 84);
            this.txtincognita1.MaxLength = 5;
            this.txtincognita1.Name = "txtincognita1";
            this.txtincognita1.Size = new System.Drawing.Size(100, 30);
            this.txtincognita1.TabIndex = 1;
            // 
            // btnARectangulo
            // 
            this.btnARectangulo.BackColor = System.Drawing.Color.Goldenrod;
            this.btnARectangulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnARectangulo.Location = new System.Drawing.Point(24, 261);
            this.btnARectangulo.Name = "btnARectangulo";
            this.btnARectangulo.Size = new System.Drawing.Size(180, 43);
            this.btnARectangulo.TabIndex = 3;
            this.btnARectangulo.Text = "Área de un rectángulo";
            this.btnARectangulo.UseVisualStyleBackColor = false;
            this.btnARectangulo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "A = x * y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Primera Incognita (x)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Segunda Incognita (y)";
            // 
            // txtincognita2
            // 
            this.txtincognita2.Location = new System.Drawing.Point(322, 134);
            this.txtincognita2.MaxLength = 5;
            this.txtincognita2.Name = "txtincognita2";
            this.txtincognita2.Size = new System.Drawing.Size(100, 30);
            this.txtincognita2.TabIndex = 6;
            // 
            // txtresultado
            // 
            this.txtresultado.Enabled = false;
            this.txtresultado.Location = new System.Drawing.Point(322, 187);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 30);
            this.txtresultado.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resultado";
            // 
            // btnATringulo
            // 
            this.btnATringulo.BackColor = System.Drawing.Color.Goldenrod;
            this.btnATringulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnATringulo.Location = new System.Drawing.Point(402, 259);
            this.btnATringulo.Name = "btnATringulo";
            this.btnATringulo.Size = new System.Drawing.Size(180, 45);
            this.btnATringulo.TabIndex = 9;
            this.btnATringulo.Text = "Área de un triangulo";
            this.btnATringulo.UseVisualStyleBackColor = false;
            this.btnATringulo.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "A = ( x * y ) /2";
            // 
            // btnACuadrado
            // 
            this.btnACuadrado.BackColor = System.Drawing.Color.Goldenrod;
            this.btnACuadrado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnACuadrado.Location = new System.Drawing.Point(216, 261);
            this.btnACuadrado.Name = "btnACuadrado";
            this.btnACuadrado.Size = new System.Drawing.Size(180, 43);
            this.btnACuadrado.TabIndex = 11;
            this.btnACuadrado.Text = "Área de un cuadrado";
            this.btnACuadrado.UseVisualStyleBackColor = false;
            this.btnACuadrado.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "A = x * x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 333);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnACuadrado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnATringulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtincognita2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnARectangulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtincognita1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio #3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtincognita1;
        private System.Windows.Forms.Button btnARectangulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtincognita2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnATringulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnACuadrado;
        private System.Windows.Forms.Label label7;
    }
}

