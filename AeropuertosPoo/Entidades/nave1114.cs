using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AeropuertosPoo.Entidades
{
    public class nave1114 : Aeronave, iAeronave
    {
        public nave1114(string matri) : base(matri)
        {
            autonimia = 1500;//Supuesta autonomia
            //Inicializo el objeto Capacidad para poder devolverlo
            _capacidad = new Capacidad();
            _capacidad.turista = 12;
            _capacidad.ejecutivo = 8;
        }

        public Capacidad getCapacidad()
        {
            return _capacidad;
        }
    }
}
