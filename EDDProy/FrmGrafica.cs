using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public partial class FrmGrafica : Form
    {
        public FrmGrafica()
        {
            InitializeComponent();
        }

        private void frmGrafica_Load(object sender, EventArgs e)
        {

        }
        public void ActualizaGrafica(Bitmap Img)
        {
            picGrafica.Image = Img;
        }

        private void picGrafica_Click(object sender, EventArgs e)
        {

        }

        private void FrmGrafica_Load_1(object sender, EventArgs e)
        {

        }
    }
}
