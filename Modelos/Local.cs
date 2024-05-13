using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioAgusFioSofi
{
    internal class Local
    {
        public int IdLocal { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }

        public Responsable Responsable { get; set; }
    }
}
