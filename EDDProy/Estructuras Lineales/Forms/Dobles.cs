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
    public partial class Dobles : Form
    {
        Doble dobles= new Doble();
        public Dobles()
        {
            InitializeComponent();
        }
        
        private void Dobles_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            dobles.Insertar(int.Parse(txtDato.Text));
            txtDato.Text = "";
            txtDato.Focus();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dobles = new Doble();
        }

        private void btnVerList_Click(object sender, EventArgs e)
        {
            txtList.Text = "";
            if (btnVerList.Text == "Ver lista ID")
            {
                dobles.IzquierdaD(txtList);
                btnVerList.Text = "Ver lista D-I";
            }
            else
            {
                dobles.DerechaI(txtList);
                btnVerList.Text = "Ver lista I-D";
            }
        }

        private void txtList_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
