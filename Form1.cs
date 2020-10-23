using Parcial2.controlador;
using Parcial2.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void currencyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (camisa.Checked)
            {
                bermuda.Checked = false;
                bermuda.Enabled = false;
                mangaCorta.Checked = false;
                mangaCorta.Enabled = true;
            }
            if (pantalon.Checked)
            {
                bermuda.Checked = false;
                bermuda.Enabled = true;
                mangaCorta.Checked = false;
                mangaCorta.Enabled = false;
            }
        }

        private void keyPressIsNumber(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void calcularPrecio(object sender, EventArgs e)
        {
            double precioTotal = 0;
            if(!this.cantidad.Text.Equals("") && !this.price.Text.Equals(""))
            {
                if (camisa.Checked) {                    
                    ControladorPrecio controladorPrecio = new ControladorPrecio();
                    precioTotal = controladorPrecio.calcularPrecioCamisas(Double.Parse(price.Text), Int16.Parse(cantidad.Text), (standard.Checked) ? "Standard" : "Premium", mangaCorta.Checked);
                }
                else if(pantalon.Checked){
                    ControladorPrecio controladorPrecio = new ControladorPrecio();
                    precioTotal = controladorPrecio.calcularPrecioPantalones(Double.Parse(price.Text), Int16.Parse(cantidad.Text), (standard.Checked) ? "Standard" : "Premium", bermuda.Checked);
                }
                MessageBox.Show("El precio total es: $" + precioTotal);
            }
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            if (!this.cantidad.Text.Equals("") && !this.price.Text.Equals(""))
            {
                this.calcular.Enabled = true;
            }
            else
            {
                this.calcular.Enabled = false;
            }
        }

        private void cantidad_TextChanged(object sender, EventArgs e)
        {
            if (!this.cantidad.Text.Equals("") && !this.price.Text.Equals(""))
            {
                this.calcular.Enabled = true;
            }
            else
            {
                this.calcular.Enabled = false;
            }
        }
    }
}
