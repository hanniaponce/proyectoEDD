using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
 
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            //Se inserta el nodo con el dato capturado
            miArbol.InsertaNodo(int.Parse(txtDato.Text), ref miRaiz);

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            
            txtDato.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text  = "";
            txtDato.Text = "";
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblPre.Text = "El arbol esta vacio";
                return;
            }
            lblPre.Text = "";
            miArbol.PreOrden(miRaiz);

            lblPre.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblPost.Text = "El arbol esta vacio";
                return;
            }
            lblIn.Text = "";
            miArbol.InOrden(miRaiz);
            lblIn.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblPost.Text = "El arbol esta vacio";
                return;
            }
            lblPost.Text = "";
            miArbol.PostOrden(miRaiz);
            lblPost.Text = miArbol.strRecorrido;

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";

            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos = 1; nNodos <= txtNumero.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void btnHojas_Click(object sender, EventArgs e)
        {
            int totalHojas = miArbol.ContarHojas(miRaiz);
            txtDato.Text = " " + totalHojas;
        }

        private void btnPodar_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El arbol est avacio");
                return;
            }
            int dato = int.Parse(txtDato.Text);

            miArbol.PodarArbol(dato, ref miRaiz);

            if (miRaiz == null)
            {
                MessageBox.Show("Nodo eliminado.");
                txtDato.Text = "";
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            {
                if (int.TryParse(txtDato.Text, out int dato))
                {
                    miArbol.EliminarPredecesor(dato, ref miRaiz);
                    MessageBox.Show($"El predecesor del nodo con el dato{dato} eliminado si existia.");
                }
                else
                {
                    MessageBox.Show("Ingresar un numero valido.");
                }
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtDato.Text);
            miRaiz = miArbol.RegresaRaiz();

            if (miArbol.BuscarNodo(valor, miRaiz))
            {
                MessageBox.Show("El nodo ya existe en el árbol.");
                txtDato.Text = "";
                return;
            }
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {

            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString = b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);


            FrmGrafica graf = new FrmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }

        private void btnSuc_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int dato))
            {
                miArbol.EliminarSucesor(dato, ref miRaiz);
                MessageBox.Show($"El sucesor del nodo con el dato{dato} eliminado si existia.");
            }
            else
            {
                MessageBox.Show("Ingresar un numero valido.");
            }
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                lblAlt.Text = "El arbol se encuentra vacio.";
                return;
            }
            int altura = miArbol.Altura(miRaiz);
            lblAlt.Text = " " + altura;
        }

        private void btnNiveles_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = " ";
            if (miRaiz == null)
            {
                lblNivel.Text = "El arbol se encuentra vacio.";
                return;
            }
            miArbol.RecorridoNiveles(miRaiz);
            lblNivel.Text = miArbol.strRecorrido;
        }

        private void btnCompleto_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            bool Completo = miArbol.ArbolCompleto(miRaiz);
            lblCom.Text = Completo ? "El arbol se encuentra completo." : "El arbol no se encuentra completo.";
        }
    }
}
