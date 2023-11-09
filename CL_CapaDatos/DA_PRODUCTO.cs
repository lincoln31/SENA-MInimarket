using CL_CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_CapaDatos
{
    public class DA_PRODUCTO:DA_BASE
    {

        public static bool insertarCliente(Cliente objCliente)
        {
            string strSQL = "INSERT INTO cliente " +
                "(tipoDoc,  identificacion,nombres,apellidos,correo,celular) values(";
            strSQL += "'" + objCliente.tipoDoc + "',";
            strSQL += "'" + objCliente.identificacion + "',";
            strSQL += "'" + objCliente.nombres + "',";
            strSQL += "'" + objCliente.apellidos + "',";
            strSQL += "'" + objCliente.correo + "',";
            strSQL += "'" + objCliente.celular + "');";

            return RealizarTransaccion(strSQL);
        }

        public static DataTable consultarCliente()
        {
            DataTable dt = new DataTable();

            string strSQL = "SELECT * FROM cliente;";

            return consultarDatos(strSQL);

        }
        public static bool actualizarCliente(Cliente objCliente)
        {
            string strSQL = "UPDATE cliente SET ";

            strSQL += "tipoDoc = '" + objCliente.tipoDoc + "',";
            strSQL += "nombres = '" + objCliente.nombres + "',";
            strSQL += "apellidos = '" + objCliente.apellidos + "',";
            strSQL += "correo = '" + objCliente.correo + "',";
            strSQL += "celular = '" + objCliente.celular + "' ";

            strSQL += " WHERE identificacion = '" + objCliente.identificacion + "';";

            return RealizarTransaccion(strSQL);
        }


    }
}
