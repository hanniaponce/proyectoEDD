using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales.Clases;

namespace EDDemo.Estructuras_Lineales.Forms
{
    public partial class Circulares : Form
    {
        Circular circulares = new Circular();
        public Circulares()
        {
            InitializeComponent();
        }


        public void Lista()
        {
            lstCirculares.Items.Clear();
            var Datos = circulares.Datos();
            foreach (var dato in Datos)
            {
                lstCirculares.Items.Add(dato);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDato.Text))
            {
                circulares.Agregar(txtDato.Text);
                txtDato.Clear();
                txtDato.Focus();
                Lista();

            }
            else
            {
                MessageBox.Show("Dato invalido.");

            }
        }

        private void Circulares_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lstCirculares.Text.Trim(), out int posicion))
            {
                circulares.Eliminar(posicion);
                lstCirculares.Text = "";
                Lista();
            }
        }
    }
}
