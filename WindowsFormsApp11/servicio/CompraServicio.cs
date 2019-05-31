using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp11.modelo;

namespace WindowsFormsApp11.servicio
{
    class CompraServicio
    {
        public static double Sumar(Compra compra1,Compra compra2)
        {
            double r=0;
            r=compra1.Precio+compra2.Precio;
            //r=compra1+compra2;

            return r;
        }
        public static Compra Factory(TextBox texto1,NumericUpDown texto2)
        {
            Compra compra=new Compra(); 
            compra.Nombre=texto1.Text;
            compra.Precio=Convert.ToDouble(texto2.Text);
            return compra;
        }
    }
}
