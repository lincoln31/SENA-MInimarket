using CL_CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_CapaDatos;
using System.Data;

namespace CL_CapaNegocio
{
    public class CN_PROVEEDOR
    {
        public static bool insertarProveedor(Proveedor objProveedor)
        {
            return DA_PROVEEDOR.insertarProveedor(objProveedor);
        }
        public static DataTable consultarProveedores()
        {
            return DA_PROVEEDOR.consultarProveedores();
        }
        public static bool actualizarProveedor(Proveedor objProveedor)
        {
            return DA_PROVEEDOR.actualizarProveedor(objProveedor);
        }
    }
}
