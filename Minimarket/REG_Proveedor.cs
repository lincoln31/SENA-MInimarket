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
    public partial class REG_Proveedor : Form
    {
        public REG_Proveedor()
        {
            InitializeComponent();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            Proveedor objProveedor= new Proveedor();

            objProveedor.Nit=textBox_NIT.Text.Trim();
            objProveedor.RazonSocial=textBox_RZ.Text.Trim();
            objProveedor.Telefono=textBox_TEL.Text.Trim();
            objProveedor.Correo=textBox_EMAIL.Text.Trim();
            objProveedor.Correo=textBox_EMAIL.Text.Trim();
            objProveedor.Nomeclaturas=textBox_NOM.Text.Trim();
            objProveedor.Ciudad=textBox_CIUDAD.Text.Trim();
            objProveedor.Departamento=textBox_DEP.Text.Trim();

            if (CN_PROVEEDOR.insertarProveedor(objProveedor))
            {
                MessageBox.Show("Registro exitoso");

                


            }
            else
            {
                MessageBox.Show("Fallo en la insercion");
            }


        }
    }
}
