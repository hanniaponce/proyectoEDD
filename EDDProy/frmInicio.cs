using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Busqueda.Forms;
using EDDemo.Estructuras_Lineales.Forms;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Ordenamiento.Forms;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pilas frmPila = new Pilas();
            frmPila.MdiParent = this;
            frmPila.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaE frmLista = new ListaE();
            frmLista.MdiParent = this;
            frmLista.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colas frmColas = new Colas();
            frmColas.MdiParent = this;
            frmColas.Show();
        }

        private void doblementeEncadenadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dobles frmDobles = new Dobles();
            frmDobles.MdiParent = this;
            frmDobles.Show();
        }

        private void listasCircularesSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Circulares frmCirculares = new Circulares();
            frmCirculares.MdiParent = this;
            frmCirculares.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FrmBurbuja frmBurbuja=new FrmBurbuja();
            frmBurbuja.MdiParent = this;    
            frmBurbuja.Show();
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuickSort frmQuick = new FrmQuickSort();
            frmQuick.MdiParent = this;
            frmQuick.Show();
        }

        private void shellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShellSort frmShell = new FrmShellSort();
            frmShell.MdiParent = this;
            frmShell.Show();
        }

        private void radixSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRadixSort frmRadix = new FrmRadixSort();
            frmRadix.MdiParent = this;
            frmRadix.Show();
        }

        private void binariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBBin frmBBin = new FrmBBin();
            frmBBin.MdiParent = this;
            frmBBin.Show();
        }

        private void hashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHash frmHash = new FrmHash();
            frmHash.MdiParent = this;
            frmHash.Show();
        }

        private void ordenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
