using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeropuertosPoo.Entidades
{
    public class AeronaveManagement : iAeronave
    {
        private Aeronave avion;

            public AeronaveManagement(Aeronave avion)
        {
            this.avion = avion;
        }

        public Capacidad getCapacidad()
        {
            Capacidad capa = new Capacidad();
            switch (avion.modelo)
            {
                case "MB814":
                    capa.turista = 8;
                    capa.ejecutivo = 2;
                    break;
                case "MB1418":
                    capa.turista = 14;
                    capa.ejecutivo = 6;
                    break;
                case "MB114":
                    capa.turista = 12;
                    capa.ejecutivo = 8;
                    break;
            }
            return capa;
        }
    }
}
