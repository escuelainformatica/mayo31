using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp11.modelo;
using WindowsFormsApp11.servicio;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // crear dos objetos.
            int variable=20;
            string texto="aaa";
            Compra compra1=new Compra();
            Compra compra2 = new Compra();
            compra1=CompraServicio.Factory(textBox1,textBox2);
            compra2 = CompraServicio.Factory(textBox5, textBox4);

            double total=CompraServicio.Sumar(compra1,compra2);

            textBox3.Text=total.ToString();


        }
    }
}
