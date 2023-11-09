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
    



    public partial class UPD_Cliente : Form
    {



        Boolean flag;
        public UPD_Cliente()
        {
            InitializeComponent();

            flag = false;
            editar(flag);
        }
        public void editar(Boolean flag)
        {
            textBox_TDOCUMENTO.Enabled = flag;
            textBox_IDE.Enabled = flag;
            textBox_NOMBRE.Enabled = flag;
            textBox_APELLIDO.Enabled = flag;
            textBox_EMAIL.Enabled = flag;
            textBox_TEL.Enabled = flag; ;
        }
        public void consultar()
        {
            dataGridView1.Visible = true;
            DataTable dataTable = new DataTable();
            dataTable = CN_CLIENTE.consultarCliente();

            dataGridView1.DataSource = dataTable;

        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            consultar();
        }

        private void Actualizar_Click(object sender, EventArgs e)

        
        {

             flag = true;

            editar(flag);
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];

               String valor = fila.Cells[0].Value.ToString();
                textBox_TDOCUMENTO.SelectedItem = valor;
                textBox_IDE.Text= fila.Cells[1].Value.ToString();
                textBox_NOMBRE.Text = fila.Cells[2].Value.ToString();
                textBox_APELLIDO.Text = fila.Cells[3].Value.ToString();
                textBox_EMAIL.Text = fila.Cells[4].Value.ToString();
                textBox_TEL.Text = fila.Cells[5].Value.ToString();

                textBox_IDE.Enabled = false;



            }
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();


            
            objCliente.tipoDoc = textBox_TDOCUMENTO.SelectedItem.ToString();
            objCliente.identificacion = textBox_IDE.Text.Trim();            
            objCliente.nombres = textBox_NOMBRE.Text.Trim();
            objCliente.apellidos = textBox_APELLIDO.Text.Trim();
            objCliente.correo = textBox_EMAIL.Text.Trim();
            objCliente.celular = textBox_TEL.Text.Trim();

            if (CN_CLIENTE.actualizarCliente(objCliente))
            {
                MessageBox.Show("Actualizacion exitoso");

                textBox_IDE.Text = " ";
                textBox_NOMBRE.Text = "";
                textBox_APELLIDO.Text = "";
                textBox_EMAIL.Text = "";
                textBox_TEL.Text = ""; ;

                consultar();



            }
            else
            {
                MessageBox.Show("Fallo en la insercion");
            }
        }
    }
}
