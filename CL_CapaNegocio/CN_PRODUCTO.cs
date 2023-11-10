using CL_CapaDatos;
using CL_CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_CapaNegocio
{
    public class CN_PRODUCTO
    {

        public static bool insertarProducto(Producto objProducto)
        {
            return DA_PRODUCTO.insertarProducto(objProducto);
        }
        public static DataTable consultarProducto()
        {
            return DA_PRODUCTO.consultarProducto();
        }
        //public static bool actualizarProducto(Producto objProducto)
        //{
        //    return DA_PRODUCTO.actualizarProducto(objProducto);
        //}
        public static DataTable poblarComboBox()
        {
            return DA_PRODUCTO.poblarComboBox();
        }
    }
}
