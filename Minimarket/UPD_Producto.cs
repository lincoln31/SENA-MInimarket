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
    public partial class UPD_Producto : Form
    {
        public UPD_Producto()
        {
            InitializeComponent();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            DataTable dataTable = new DataTable();
            dataTable = CN_PRODUCTO.consultarProducto();

            dataGridView1.DataSource = dataTable;
        }
    }
}
