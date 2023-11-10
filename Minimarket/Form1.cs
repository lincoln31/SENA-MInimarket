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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void miniMarketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UPD_Marketin ObjFrm = new UPD_Marketin();

            ObjFrm.MdiParent = this;

            ObjFrm.Show();

            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void rEGISTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REG_Proveedor ObjFRM = new REG_Proveedor();
            ObjFRM.MdiParent = this;
            ObjFRM.Show();
            ObjFRM.WindowState=FormWindowState.Maximized;

        }

        private void cONSULTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UPD_Proveedor ObjFRM = new UPD_Proveedor();
            ObjFRM.MdiParent = this;
            ObjFRM.Show();
            ObjFRM.WindowState = FormWindowState.Maximized;


        }

        private void rEGISTRARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            REG_Cliente ObjFRM = new REG_Cliente();
            ObjFRM.MdiParent = this;
            ObjFRM.Show();
            ObjFRM.WindowState = FormWindowState.Maximized;

        }

        private void cONSULTARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UPD_Cliente ObjFRM = new UPD_Cliente();
            ObjFRM.MdiParent = this;
            ObjFRM.Show();
            ObjFRM.WindowState = FormWindowState.Maximized;

        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            REG_Categoria ObjFRM = new REG_Categoria();
            ObjFRM.MdiParent = this;
            ObjFRM.Show();
            ObjFRM.WindowState = FormWindowState.Maximized;
        }

        private void cONSULTARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UPD_Categoria ObjFRM = new UPD_Categoria();
            ObjFRM.MdiParent = this;
            ObjFRM.Show();
            ObjFRM.WindowState = FormWindowState.Maximized;

        }

        private void rEGISTRARToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            REG_Producto ObjFRM = new REG_Producto();
            ObjFRM.MdiParent = this;
            ObjFRM.Show();
            ObjFRM.WindowState = FormWindowState.Maximized;

        }

        private void cONSULTARToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            UPD_Proveedor ObjFRM = new UPD_Proveedor();
            ObjFRM.MdiParent = this;
            ObjFRM.Show();
            ObjFRM.WindowState = FormWindowState.Maximized;


        }
    }
}
