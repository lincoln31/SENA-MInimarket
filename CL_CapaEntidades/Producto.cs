using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_CapaEntidades
{
    public class Producto
    {

        public string nombre { get; set; }
        public string marca { get; set; }
        public int stock { get; set; }

        public int pvp { get; set; }
        public string descripcion { get; set; }
        public string unidadMedida { get; set; }
        public int idCategoria { get; set; }
        
    }
}
