using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Busqueda.Class;

namespace EDDemo.Busqueda.Forms
{
    public partial class FrmBBin : Form
    {
        private readonly BusquedaBin busquedaBin;
        public FrmBBin()
        {
            InitializeComponent();
            busquedaBin = new BusquedaBin();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmBBin_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arreglo = txtNum.Text
                    .Split(',')
                    .Select(int.Parse)
                    .OrderBy(x => x) 
                    .ToArray();

                int objetivo = int.Parse(txtBus.Text);
                int resultado = busquedaBin.Buscar(arreglo, objetivo);

                lstRe.Items.Clear();
                if (resultado != -1)
                    lstRe.Items.Add($"El Numero {objetivo} se encontró en el índice {resultado}.");
                else
                    lstRe.Items.Add($"El Numero {objetivo} no se encuentra en el arreglo.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
