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
    public partial class ListaE : Form
    {
        Lista Enlazada = new Lista();
        public ListaE()
        {
            InitializeComponent();
        }

        private void ListaE_Load(object sender, EventArgs e)
        {

        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            if (txtDato.Text != "")
            {
                Nodo nodo = new Nodo();
                nodo.Dato = txtDato.Text;
                Enlazada.AFinal(nodo);
                Mostrar();
                txtDato.Text = "";
                txtDato.Focus();

            }
        }
        void AgregarItem(Nodo nodo)
        {
            if (nodo != null)
            {
                lstLista.Items.Add(nodo.Dato);
                AgregarItem(nodo.Siguiente);
            }
        }
        public void Mostrar()
        {
            lstLista.Items.Clear();
            if (Enlazada.Inicio != null)
            {
                AgregarItem(Enlazada.Inicio);
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (txtDato.Text != "")
            {
                Nodo nodo = new Nodo();
                nodo.Dato = txtDato.Text;
                Enlazada.AInicio(nodo);
                Mostrar();
                txtDato.Text = "";
                txtDato.Focus();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstLista.SelectedItem != null)
            {

                string datoAEliminar = lstLista.SelectedItem.ToString();
                Enlazada.Eliminar(datoAEliminar);

                // Actualiza la vista
                Mostrar();
            }
            else
            {
                MessageBox.Show("Selecciona el dato a eliminar");
            }
        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
