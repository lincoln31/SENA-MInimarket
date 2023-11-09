using CL_CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CL_CapaDatos
{
    public class DA_PROVEEDOR:DA_BASE
    {
        public static bool insertarProveedor(Proveedor objProveedor)
        {
            string strSQL = "INSERT INTO proveedor " +
                "(nit, razonSocial, telefono, correo,nomeclaturas,ciudad,departamento) values(";
            strSQL += "'" + objProveedor.Nit + "',";
            strSQL += "'" + objProveedor.RazonSocial + "',";
            strSQL += "'" + objProveedor.Telefono + "',";
            strSQL += "'" + objProveedor.Correo + "',";
            strSQL += "'" + objProveedor.Nomeclaturas + "',";
            strSQL += "'" + objProveedor.Ciudad + "',";
            strSQL += "'" + objProveedor.Departamento + "');";

            return RealizarTransaccion(strSQL);
        }
        public static DataTable consultarProveedores()
        {
            DataTable dt = new DataTable();

            string strSQL = "SELECT * FROM proveedor;";

            return consultarDatos(strSQL);

        }
        public static bool actualizarProveedor(Proveedor objProveedor)
        {
            string strSQL = "UPDATE proveedor SET ";


            strSQL += "razonSocial = '" + objProveedor.RazonSocial + "', ";
            strSQL += "telefono = '" + objProveedor.Telefono + "', ";
            strSQL += "correo = '" + objProveedor.Correo + "', ";
            strSQL += "nomeclaturas = '" + objProveedor.Nomeclaturas + "', ";
            strSQL += "ciudad = '" + objProveedor.Ciudad + "', ";
            strSQL += "departamento = '" + objProveedor.Departamento + "' ";
            
            

            strSQL += " WHERE nit = '"+ objProveedor.Nit+"';";


            return RealizarTransaccion(strSQL);

        }


    }
}
