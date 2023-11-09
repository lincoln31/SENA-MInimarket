
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_CapaDatos;
using CL_CapaEntidades;

namespace CL_CapaNegocio
{
    public class CN_MARKET
    {
        public static DataTable consultarMarket()
        {
            return DA_MARKET.consultarMarket();
        }
        public static bool actualizarMarket(Market objFullmarket)
        {
            return DA_MARKET.actualizarMarket(objFullmarket);
        }
    }
}
