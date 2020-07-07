using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AeropuertosPoo.Entidades;

namespace AeropuertosPoo.Datos
{
    public class SingletonDatos
    {
        private static SingletonDatos _shared = null;
        // el constructor es privado para no poder instanciar desde afuera
        private SingletonDatos() {
            aerolineas = new List<Aerolinea>();
        }
        public static SingletonDatos shared //esta es la variable por la cual se accede a la instancia
        {
            get
            {
                if( _shared == null)
                {
                    _shared = new SingletonDatos();
                }

                return _shared;
             }
        }
        //Aqui guardo lo que nececito
        public List<Aerolinea> aerolineas { get; set; }
        public List<Vuelo> vuelos { get; set; }
    }
}
