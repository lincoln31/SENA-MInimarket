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
    public class CN_CLIENTE
    {
        public static bool insertarCliente(Cliente objCliente)
        {
            return DA_CLIENTE.insertarCliente(objCliente);
        }

        public static DataTable consultarCliente()
        {
            return DA_CLIENTE.consultarCliente();
        }
        public static bool actualizarCliente(Cliente objCliente)
        {
            return DA_CLIENTE.actualizarCliente(objCliente);
        }
    }
}
