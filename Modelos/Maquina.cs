using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioAgusFioSofi
{
    internal class Maquina
    {
        public int IdMaquina { get; set; }
        public Local LocalAsociado { get; set; }
        public DateTime FechaCompra { get; set; }
        public int PrecioCompra { get; set; }
        public int VidaUtil { get; set; }
        public TipoMaquina TipoMaquina { get; set; }
        public string Disponible { get; set; }

    }
}
