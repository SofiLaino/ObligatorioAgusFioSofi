using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioAgusFioSofi
{
    internal class Socio : Persona
    {
        public int IdSocio { get; set; }
        public string Tipo { get; set; }
        public string Email { get; set; }
        public Local LocalAsociado { get; set; }
    }
}
