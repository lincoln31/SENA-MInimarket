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
    public class CN_CATEGORIA
    {

        public static bool insertarCategoria(Categoria objCategoria)
        {
            return DA_CATEGORIA.insertarCategoria(objCategoria);
        }

        public static DataTable consultarCategoria()
        {
            return DA_CATEGORIA.consultarCategoria();
        }
        public static bool actualizarCategoria(Categoria objCategoria)
        {
            return DA_CATEGORIA.actualizarCategoria(objCategoria);
        }
    }
}
