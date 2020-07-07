using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AeropuertosPoo.Datos;

namespace AeropuertosPoo.Entidades
{
    public class Vuelo
    {
        public List<Asiento> asientos { get; set;}
        public string nave { get; set; }
        public DateTime partida { get; set; }
        public string numero { get; set; }
        public string company { get; set; }
        public string destino { get; set; }
        public Estados estado { get; set; }


    }
}
