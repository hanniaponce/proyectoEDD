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
    public partial class FrmQuickSort : Form
    {
        private QuickSort quickSort;
        public FrmQuickSort()
        {
            InitializeComponent();
            quickSort = new QuickSort();
        }

        private void FrmQuickSort_Load(object sender, EventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> lista = txtDatos.Text.Split(',')
                    .Select(int.Parse)
                    .ToList();

                quickSort.Ordenar(lista);

                lstRe.Items.Clear();
                foreach (int num in lista)
                {
                    lstRe.Items.Add(num);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }
    }
}
