using Figuras.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Servicio servicio = new Servicio();
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                double rad = Convert.ToDouble(tbRadio.Text);
                IFigura circulo = new Circulo(rad);
                servicio.AgregarFigura(circulo);
            }
            else if (listBox1.SelectedIndex == 1)
            {
                double ancho = Convert.ToDouble(tbAncho.Text);
                double largo = Convert.ToDouble(tbLargo.Text);
                IFigura rectangulo = new Rectangulo(ancho, largo);
                servicio.AgregarFigura(rectangulo);
            }
            else if (listBox1.SelectedIndex == 2)
            {
                double rad = Convert.ToDouble(tbRadio.Text);
                IFigura esfera = new Esfera(rad);
                servicio.AgregarFigura(esfera);
            }
            else
            {
                double radio = Convert.ToDouble(tbRadio.Text);
                double alto = Convert.ToDouble(tbAlto.Text);
                IFigura cilindro = new Cilindro(radio, alto);
                servicio.AgregarFigura(cilindro);
            }

            lbCreadas.Items.Clear();

            for (int i = 0; i < servicio.VerCantidad(); i++)
            {
                lbCreadas.Items.Add(servicio.VerFigura(i));
            }

            tbAlto.Text = "";
            tbRadio.Text = "";
            tbAncho.Text = "";
            tbLargo.Text = "";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0 || listBox1.SelectedIndex == 2)
            {
                tbRadio.Enabled = true;
                tbAlto.Enabled = false;
                tbAncho.Enabled = false;
                tbLargo.Enabled = false;
            }
            else if (listBox1.SelectedIndex == 1)
            {
                tbRadio.Enabled = false;
                tbAlto.Enabled = false;
                tbAncho.Enabled = true;
                tbLargo.Enabled = true;
            }
            else if (listBox1.SelectedIndex == 3)
            {
                tbRadio.Enabled = true;
                tbAlto.Enabled = true;
                tbAncho.Enabled = false;
                tbLargo.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            servicio.EliminarFigura(lbCreadas.SelectedIndex);

            lbCreadas.Items.Clear();

            for (int i = 0; i < servicio.VerCantidad(); i++)
            {
                lbCreadas.Items.Add(servicio.VerFigura(i));
            }
        }
    }
}
