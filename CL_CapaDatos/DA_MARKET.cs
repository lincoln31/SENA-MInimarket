using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_CapaEntidades;

namespace CL_CapaDatos
{
    public class DA_MARKET:DA_BASE

    {
        public static DataTable consultarMarket()
        {
            DataTable dt = new DataTable();

            string strSQL = "select nit, razonSocial, telefono, nomeclatura, ciudad, departamento, correo, sitioweb, facebook, whastapp " +
                "from minimarket where idMinimarket = 1;";

            return consultarDatos(strSQL);

        }
        public static bool actualizarMarket(Market objFullmarket)
        {
            string strSQL = "UPDATE minimarket SET ";


            strSQL  += "razonSocial = '" +objFullmarket.RazonSocial+ "', " ;
            strSQL  += "telefono = '" +objFullmarket.Telefono + "', ";
            strSQL  += "nomeclatura = '" +objFullmarket.Nomeclatura + "', ";
            strSQL  += "ciudad = '" +objFullmarket.Ciudad + "', ";
            strSQL  += "departamento = '" +objFullmarket.Departamento + "', ";
            strSQL  += "correo = '" +objFullmarket.Correo + "', ";
            strSQL  += "sitioweb = '" +objFullmarket.SitionWeb + "', ";
            strSQL  += "facebook = '" +objFullmarket.Facebook + "', ";
            strSQL  += "whastapp = '" + objFullmarket.Whastapp + "' ";
            strSQL  += " WHERE idMinimarket = 1;";


              return RealizarTransaccion(strSQL);

        }
    }
}
