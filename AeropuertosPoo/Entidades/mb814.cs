using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AeropuertosPoo.Entidades
{
    class mb814 : Aeronave, iAeronave
    {
        
        public mb814(string matri) : base(matri)
        {
            autonimia = 1000;//Supuesta autonomia
            //Inicializo el objeto Capacidad para poder devolverlo
            _capacidad = new Capacidad();
            _capacidad.turista = 8;
            _capacidad.ejecutivo = 2;
        }

        public Capacidad getCapacidad()
        {
            return _capacidad;
        }
    }
}
