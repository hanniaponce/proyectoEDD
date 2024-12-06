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
    public partial class FrmRadixSort : Form
    {
        private RadixSort radix;

        public FrmRadixSort()
        {
            InitializeComponent();
            radix = new RadixSort();
        }

        private void FrmRadixSort_Load(object sender, EventArgs e)
        {

        }

        private void bntOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arreglo = txtDatos.Text.Split(',').Select(int.Parse).ToArray();
                radix.Ordenar(arreglo);

                lstRe.Items.Clear();
                foreach (int num in arreglo)
                {
                    lstRe.Items.Add(num);
                }

                MessageBox.Show("Arreglo ordenado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
