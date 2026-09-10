using Peaje.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peaje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Envio env1;
        Envio env2;

        private void button1_Click(object sender, EventArgs e)
        {
            Costo envio1 = new Fijo("Peaje puente zarate", 300);
            Costo envio2 = new Variable("Combustible en litros", 500 ,1500.50);

            env1 = new Envio();
            env1.AgregarCosto(envio1);
            env1.AgregarCosto(envio2);

            Costo envio3 = new Fijo("Peaje tunel", 300);
            Costo envio4 = new Variable("Horas de conduccion", 10, 500);

            env2 = new Envio();
            env2.AgregarCosto(envio3);
            env2.AgregarCosto(envio4);



        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = env1.VerDetalle();
            textBox1.Text +="";
            textBox1.Text += env2.VerDetalle();
        }
    }
}
