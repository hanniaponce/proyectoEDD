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
    public partial class Colas : Form
    {
        Cola cola = new Cola();
        public Colas()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cola.Vaciar())
            {
                MessageBox.Show("La cola esta vacia.");
            }
            else
            {
                cola.Desencolar();
                MostrarCola();
            }

        }

        private void Colas_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDato.Text.Length == 0)
            {
                MessageBox.Show("Dato invalido.");
            }
            else
            {
                NodoCinco NuevoNodo = new NodoCinco();
                NuevoNodo.Dato = txtDato.Text;
                cola.Encolar(NuevoNodo);
                MostrarCola();
            }
        }

        private void lstColas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MostrarCola()
        {
            lstColas.Items.Clear();
            MostrarNodo(cola.Inicio);
        }
        private void MostrarNodo(NodoCinco nodoF)

        {
            if (nodoF != null)
            {
                lstColas.Items.Add(nodoF.Dato);

                if (nodoF.Siguiente == null)
                {

                }
                else
                {
                    MostrarNodo(nodoF.Siguiente);
                }
            }
        }
    }
}

