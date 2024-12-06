using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Busqueda.Class;
using System.IO;

namespace EDDemo.Busqueda.Forms
{
    public partial class FrmHash : Form
    {
        private FrmHash hash;

        Hash hashO = new Hash(10);
        public FrmHash()
        {
            InitializeComponent();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                int clave = int.Parse(txtClave.Text);
                string valor = txtVal.Text;

                hashO.Insertar(clave, valor); 
                MessageBox.Show($"Clave {clave} con valor '{valor}' ingresada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtClave.Clear();
                txtVal.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ingresar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int clave = int.Parse(txtClave.Text);
                string resultado = hashO.Buscar(clave); 

                lstRe.Items.Clear();
                lstRe.Items.Add($"Clave: {clave}, Valor: {resultado}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnArch_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string[] lines = File.ReadAllLines(openFileDialog.FileName);

                        foreach (var line in lines)
                        {
                            string[] parts = line.Split(',');

                            if (parts.Length == 2 && int.TryParse(parts[0], out int clave))
                            {
                                hashO.Insertar(clave, parts[1]); 
                            }
                            else
                            {
                                MessageBox.Show($"Línea inválida: {line}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        MessageBox.Show("Archivo cargado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmHash_Load(object sender, EventArgs e)
        {

        }
    }
}

