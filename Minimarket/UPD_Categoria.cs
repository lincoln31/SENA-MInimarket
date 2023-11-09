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
    public partial class UPD_Categoria : Form
    {
        int id;
        public UPD_Categoria()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void consultar()
        {
            dataGridView1.Visible = true;
            DataTable dataTable = new DataTable();
            dataTable = CN_CATEGORIA.consultarCategoria();
           
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

                id = (int)fila.Cells[0].Value;
                textBox_NOMBRE.Text = fila.Cells[1].Value.ToString();
                textBox_DESCRIPCION.Text = fila.Cells[2].Value.ToString();
                




            }
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();


            objCategoria.idCategoria = id;
            objCategoria.nombre = textBox_NOMBRE.Text.Trim();
            objCategoria.descripcion = textBox_DESCRIPCION.Text.Trim();
            

            if (CN_CATEGORIA.actualizarCategoria(objCategoria))
            {
                MessageBox.Show("Actualizacion exitoso");

                textBox_DESCRIPCION.Text = " ";
                textBox_NOMBRE.Text = "";
                

                consultar();



            }
            else
            {
                MessageBox.Show("Fallo en la insercion");
            }
        }
    }
}
