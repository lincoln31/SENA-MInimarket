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

        public static bool insertarProducto(Producto objProducto)
        {
            string strSQL = "INSERT INTO producto " +
                "(nombre, marca,stock,pvp,descripcion,unidadMedida,idCategoria) values(";
            strSQL += "'" + objProducto.nombre + "',";
            strSQL += "'" + objProducto.marca + "',";
            strSQL +=  objProducto.stock + ",";
            strSQL +=  objProducto.pvp + ",";
            strSQL += "'" + objProducto.descripcion + "',";
            strSQL += "'" + objProducto.unidadMedida + "',";
            strSQL +=  objProducto.idCategoria + ");";

            return RealizarTransaccion(strSQL);
        }

        public static DataTable consultarProducto()
        {
            DataTable dt = new DataTable();

            string strSQL = "SELECT * FROM producto;";

            return consultarDatos(strSQL);

        }
        //public static bool actualizarProducto(Producto objProducto)
        //{
        //    string strSQL = "UPDATE producto SET ";

        //    strSQL += "tipoDoc = '" + objCliente.tipoDoc + "',";
        //    strSQL += "nombres = '" + objCliente.nombres + "',";
        //    strSQL += "apellidos = '" + objCliente.apellidos + "',";
        //    strSQL += "correo = '" + objCliente.correo + "',";
        //    strSQL += "celular = '" + objCliente.celular + "' ";

        //    strSQL += " WHERE identificacion = '" + objCliente.identificacion + "';";

        //    return RealizarTransaccion(strSQL);
        //}
        public static DataTable poblarComboBox()
        {

            DataTable dt = new DataTable();

            string strSQL = "SELECT  idCategoria  , nombre FROM categoria;";

            return consultarDatos(strSQL);

        }


    }
}
