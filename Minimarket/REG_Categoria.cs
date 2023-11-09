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
    public partial class REG_Categoria : Form
    {
        public REG_Categoria()
        {
            InitializeComponent();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();

           objCategoria.nombre=textBox_NOMBRE.Text.Trim();
           objCategoria.descripcion=textBox_DESCRIPCION.Text.Trim();


            if(CN_CATEGORIA.insertarCategoria(objCategoria))
            {
                MessageBox.Show("Registro exitoso");

                
                textBox_NOMBRE.Text = "";
                textBox_DESCRIPCION.Text = "";
                




            }
            else
            {
                MessageBox.Show("Fallo en la insercion");
            }




        }
    }
}
