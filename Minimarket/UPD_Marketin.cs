using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CL_CapaNegocio;
using CL_CapaEntidades;


namespace Minimarket
{
    public partial class UPD_Marketin : Form
    {
        private Boolean f;
        public UPD_Marketin()
        {
            InitializeComponent();
            FROM_CON_MARKET();
            f = false;
            campos(f);
        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void UPD_Marketin_Load(object sender, EventArgs e)
        {

        }
        private void FROM_CON_MARKET()
        {
            this.BackColor = Color.LightSalmon;
            DataTable dataTable = new DataTable();
            dataTable = CN_MARKET.consultarMarket();
            

            textBox_NIT.Text = dataTable.Rows[0]["nit"].ToString();
            textBox_RZ.Text = dataTable.Rows[0]["razonSocial"].ToString();
            textBox_TEL.Text = dataTable.Rows[0]["telefono"].ToString();
            textBox_NOM.Text = dataTable.Rows[0]["nomeclatura"].ToString();
            textBox_CIUDAD.Text = dataTable.Rows[0]["ciudad"].ToString();
            textBox_DEP.Text = dataTable.Rows[0]["departamento"].ToString();
            textBox_EMAIL.Text = dataTable.Rows[0]["correo"].ToString();
            textBox_SWEB.Text = dataTable.Rows[0]["sitioweb"].ToString();
            textBox_FA.Text = dataTable.Rows[0]["facebook"].ToString();
            textBox_WHA.Text = dataTable.Rows[0]["whastapp"].ToString();
        }
        public void campos(Boolean flag)
        {
            textBox_NIT.Enabled = flag;
            textBox_RZ.Enabled = flag;
            textBox_TEL.Enabled = flag;
            textBox_NOM.Enabled = flag;
            textBox_CIUDAD.Enabled = flag;
            textBox_DEP.Enabled = flag;
            textBox_EMAIL.Enabled = flag;
            textBox_SWEB.Enabled = flag;
            textBox_FA.Enabled = flag;
            textBox_WHA.Enabled = flag;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f = true;
            campos(f);
            textBox_NIT.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Market ObjMarket = new Market();

            
            ObjMarket.RazonSocial = textBox_RZ.Text.Trim();
            ObjMarket.Telefono = textBox_TEL.Text.Trim();
            ObjMarket.Nomeclatura = textBox_NOM.Text.Trim();
            ObjMarket.Ciudad = textBox_CIUDAD.Text.Trim();
            ObjMarket.Departamento = textBox_DEP.Text.Trim();
            ObjMarket.Correo = textBox_EMAIL.Text.Trim();
            ObjMarket.SitionWeb = textBox_SWEB.Text.Trim();
            ObjMarket.Facebook = textBox_FA.Text.Trim();
            ObjMarket.Whastapp = textBox_WHA.Text.Trim();

            if (CN_MARKET.actualizarMarket(ObjMarket))
            {
                MessageBox.Show("Actualizasion exitoso");
                FROM_CON_MARKET();
                f = false;
                campos(f);


            }
            else
            {
                MessageBox.Show("Fallo en la insercion");
            }




        }
    }
}
