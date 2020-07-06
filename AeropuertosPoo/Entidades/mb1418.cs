using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeropuertosPoo.Entidades
{
    class mb1418 : Aeronave,iAeronave
    {
        public mb1418(string matri) : base(matri)
        {
            autonimia = 1800;
        }

        public Capacidad getCapacidad()
        {
            //Esta es una segunda estrategia para retornar la capacidad
            //De esta manera no se tiene un objeto en memoria innecesario 
            //Se crea el objeto bajo demanda
            Capacidad capa = new Capacidad();
            capa.turista = 14;
            capa.ejecutivo = 6;
            return capa;

        }
    }
}
