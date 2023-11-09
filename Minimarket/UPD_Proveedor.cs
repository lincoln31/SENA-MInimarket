using CL_CapaEntidades;
using CL_CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimarket
{
    public partial class UPD_Proveedor : Form
    {
        public UPD_Proveedor()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }

        private void UPD_Proveedor_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            }
        public void consultar()
        {
            dataGridView1.Visible = true;
            DataTable dataTable = new DataTable();
            dataTable = CN_PROVEEDOR.consultarProveedores();

            dataGridView1.DataSource = dataTable;
        }

        private void Consultar_Click(object sender, EventArgs e)

        {

            consultar();

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];

                textBox_NIT.Text = fila.Cells[0].Value.ToString();
                textBox_RZ.Text = fila.Cells[1].Value.ToString();
                textBox_TEL.Text = fila.Cells[2].Value.ToString();
                textBox_EMAIL.Text = fila.Cells[3].Value.ToString();
                textBox_NOM.Text = fila.Cells[4].Value.ToString();
                textBox_CIUDAD.Text = fila.Cells[5].Value.ToString();
                textBox_DEP.Text = fila.Cells[6].Value.ToString();


                textBox_NIT.Enabled = false;
            }

        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            Proveedor objProveedor = new Proveedor();

            objProveedor.Nit = textBox_NIT.Text.Trim();
            objProveedor.RazonSocial=textBox_RZ.Text.Trim();
            objProveedor.Telefono=textBox_TEL.Text.Trim();
            objProveedor.Correo=textBox_EMAIL.Text.Trim();
            objProveedor.Departamento=textBox_DEP.Text.Trim();
            objProveedor.Ciudad=textBox_CIUDAD.Text.Trim();
            objProveedor.Nomeclaturas=textBox_NOM.Text.Trim();


            if (CN_PROVEEDOR.actualizarProveedor(objProveedor))
            {
                MessageBox.Show("Actualizasion exitoso");

                textBox_NIT.Text = "";
                textBox_RZ.Text = "";
                textBox_TEL.Text = "";
                textBox_EMAIL.Text = "";
                textBox_NOM.Text = "";
                textBox_CIUDAD.Text = "";
                textBox_DEP.Text = "";



                consultar();
               


            }
            else
            {
                MessageBox.Show("Fallo en la insercion");
            }



        }

        private void Limpiar_Click(object sender, EventArgs e)
        {

        }

        private void textBox_NIT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
