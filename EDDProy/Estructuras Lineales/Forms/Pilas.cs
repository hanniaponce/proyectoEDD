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
    public partial class Pilas : Form
    {
        Pila pilas = new Pila();
        public Pilas()
        {
            InitializeComponent();
        }

        private void lstPilas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            pilas.Desapilar();
            VerPila();
        }

        private void Pilas_Load(object sender, EventArgs e)
        {

        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            NodoCuatro otroNodo = new NodoCuatro();
            otroNodo.Dato = txtDato.Text;

            pilas.Apilar(otroNodo);
            VerPila();
        }

        void VerPila()
        {
            lstPilas.Items.Clear();

            if (pilas.Arriba() != null)
            {
                MostrarNodo(pilas.Arriba());
            }


        }

        void MostrarNodo(NodoCuatro nodoCuatro)
        {
            lstPilas.Items.Add(nodoCuatro.Dato);

            if (nodoCuatro.Siguiente != null)
            {
                MostrarNodo(nodoCuatro.Siguiente);
            }
        }

    }
}
