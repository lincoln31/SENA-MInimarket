using CL_CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_CapaDatos
{
    public class DA_CATEGORIA:DA_BASE

    {

        public static bool insertarCategoria(Categoria objCategoria)
        {
            string strSQL = "INSERT INTO categoria " +
                "(nombre,descripcion) values(";
            strSQL += "'" + objCategoria.nombre + "',";
            strSQL += "'" + objCategoria.descripcion + "');";
           

            return RealizarTransaccion(strSQL);
        }

        public static DataTable consultarCategoria()
        {
            DataTable dt = new DataTable();

            string strSQL = "SELECT * FROM categoria;";

            return consultarDatos(strSQL);

        }
        public static bool actualizarCategoria(Categoria objCategoria)
        {
            string strSQL = "UPDATE categoria SET ";

            strSQL += "nombre = '" + objCategoria.nombre + "', ";
            strSQL += "descripcion = '" + objCategoria.descripcion + "' ";
            

            strSQL += " WHERE idCategoria = '" + objCategoria.idCategoria + "';";

            return RealizarTransaccion(strSQL);
        }
    }
}
