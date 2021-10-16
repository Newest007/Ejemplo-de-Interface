using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_de_Interface
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtincognita1.Text == "" || txtincognita2.Text == "")
            {
                
               MessageBox.Show("Debe de ingresar las respectivas incognitas si desea realizar esa operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else
            {
                IArea areacuadrado = new ÁreaRectangulo();
                areacuadrado.Incognita1 = Convert.ToDouble(txtincognita1.Text);
                areacuadrado.Incognita2 = Convert.ToDouble(txtincognita2.Text);
                areacuadrado.calcularArea();
                txtresultado.Text = Convert.ToString(areacuadrado.Resultado);
            }
            
            txtincognita1.Clear();
            txtincognita2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtincognita1.Text == "" || txtincognita2.Text == "")
            {

                MessageBox.Show("Debe de ingresar las respectivas incognitas si desea realizar esa operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                IArea areatriangulo = new ÁreaTriangulo();
                areatriangulo.Incognita1 = Convert.ToDouble(txtincognita1.Text);
                areatriangulo.Incognita2 = Convert.ToDouble(txtincognita2.Text);
                areatriangulo.calcularArea();
                txtresultado.Text = Convert.ToString(areatriangulo.Resultado);
            }

            txtincognita1.Clear();
            txtincognita2.Clear();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (txtincognita1.Text == "")
            {

                MessageBox.Show("Debe de ingresar las respectivas incognitas si desea realizar esa operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                IArea areacuadrado = new ÁreaCuadrado();
                areacuadrado.Incognita1 = Convert.ToDouble(txtincognita1.Text);
                areacuadrado.calcularArea();
                txtresultado.Text = Convert.ToString(areacuadrado.Resultado);
            }

            txtincognita1.Clear();
            txtincognita2.Clear();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            

        }
    }
}
