using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmOrgFerro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDistancia.Text == "" || txtDestino.Text == "" || cmbDias.SelectedIndex == -1)
            {
                MessageBox.Show("Complete los datos");
            }
            else
            {

                //variables
                string destino;
                double distancia;
                double distanciaTotal;
                int dias;
                double precioBase;
                double preciofinal;
                string datos;


                destino = txtDestino.Text;
                distancia = Convert.ToDouble(txtDistancia.Text); //todouble convierte el texto a num decimal
                dias = Convert.ToInt32(cmbDias.SelectedItem); //toInt32 convierte a numero entero
                distanciaTotal = distancia * 500; //calcula distancia total de ida y vuelta
                precioBase = distanciaTotal * 400; // calcula el precio base

                datos = "Destino: " + destino + "\n" + "Distancia ingresada: " + distancia + "km\n" + "Distancia ida y vuelta: " + distanciaTotal + "km\n" + "Precio base: $ " + precioBase;

                MessageBox.Show(datos, "Calculo de boleto Ferro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (distancia >= 100 && dias >= 7)
                {
                    preciofinal = precioBase / 2;
                    datos = datos + "Descuento 50% aplicada \n";

                }
                else {
                    preciofinal = precioBase;
                    datos = datos + "Sin descuento \n";
                
                datos = datos + "Precio final: $" + preciofinal;
                MessageBox.Show(datos, "Calculo de boleto Ferro", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
           }
       }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
