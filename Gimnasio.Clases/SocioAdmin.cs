using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Clases
{
    public class SocioAdmin
    {
        public int idSocio { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string nombreGenero { get; set; }
        public DateTime fechaDeInscripcion { get; set; }
        public string nombreEstado { get; set; }
        public DateTime fechaUltimoPago { get; set; }
    }
}
