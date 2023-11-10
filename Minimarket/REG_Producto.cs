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
    public partial class REG_Producto : Form
    {
        public REG_Producto()
        {
            InitializeComponent();
            cargarComboBox();
        }

        private void textBox_UDM_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_CATEGORIA_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }
        private void cargarComboBox()
        {
            DataTable dataTable = new DataTable();
            dataTable = CN_PRODUCTO.poblarComboBox();

            if (dataTable.Rows.Count > 0)
            {
                comboBox_CATEGORIA.DataSource = dataTable;
                comboBox_CATEGORIA.DisplayMember = "nombre";
                comboBox_CATEGORIA.ValueMember = "idCategoria";



            }
        }

        private void textBox_STOCK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) 
            {
                e.Handled = true; 
            }
        }

        private void textBox_PVP_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            Producto objproducto = new Producto();

            objproducto.nombre=textBox_NOMBRE.Text.Trim();
            objproducto.marca=textBox_MARCA.Text.Trim();
            objproducto.stock = int.Parse(textBox_STOCK.Text);
            objproducto.pvp= int.Parse(textBox_PVP.Text);
            objproducto.descripcion =textBox_DESCRIPCION.Text.Trim();
            objproducto.unidadMedida = textBox_UDM.SelectedItem.ToString();
            objproducto.idCategoria= comboBox_CATEGORIA.SelectedValue.ToString();

            if (CN_PRODUCTO.insertarProducto(objproducto))
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
