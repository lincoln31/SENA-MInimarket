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
    public partial class REG_Cliente : Form
    {
        Boolean flag;
        public REG_Cliente()
        {
            InitializeComponent();
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void REG_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();

            objCliente.tipoDoc=textBox_TDOCUMENTO.SelectedItem.ToString();
            objCliente.identificacion=textBox_IDE.Text.Trim();
            objCliente.nombres=textBox_NOMBRE.Text.Trim();
            objCliente.apellidos=textBox_APELLIDO.Text.Trim();
            objCliente.correo=textBox_EMAIL.Text.Trim();
            objCliente.celular=textBox_TEL.Text.Trim();

            if (CN_CLIENTE.insertarCliente(objCliente))
            {
                MessageBox.Show("Registro exitoso");
                
                textBox_IDE.Text =" ";
                textBox_NOMBRE.Text = "";
                textBox_APELLIDO.Text = "";
                textBox_EMAIL.Text = "";
                textBox_TEL.Text = ""; ;




            }
            else
            {
                MessageBox.Show("Fallo en la insercion");
            }


        }
    }
}
