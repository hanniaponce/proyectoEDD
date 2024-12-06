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
    public partial class FrmShellSort : Form
    {
        private ShellSort shellSort;
        public FrmShellSort()
        {
            InitializeComponent();
            shellSort = new ShellSort();
        }

        private void FrmShellSort_Load(object sender, EventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                
                List<int> lista = txtDato.Text.Split(',')
                    .Select(int.Parse)
                    .ToList();

                
                shellSort.Ordenar(lista);

                
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
