using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Ordenamiento.Class;

namespace EDDemo.Ordenamiento.Forms
{
    public partial class FrmBurbuja : Form
    {
        private Burbuja burbuja;
        public FrmBurbuja()
        {
            InitializeComponent();
            burbuja = new Burbuja();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
               
                int[] numeros = txtDatos.Text
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                
                burbuja.MetodoBurbuja(numeros);

                lstRe.Items.Clear();
                foreach (int num in numeros)
                {
                    lstRe.Items.Add(num);
                }

                MessageBox.Show("Ordenamiento completado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Asegúrese de ingresar números válidos separados por comas.\n" + ex.Message);
            }
        }

        private void FrmBurbuja_Load(object sender, EventArgs e)
        {

        }
    }
}
