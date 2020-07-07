using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AeropuertosPoo.Datos;

namespace AeropuertosPoo.Entidades
{
    class VueloManagement
    {
        private Vuelo _vuelo;

        #region Constructores
        public VueloManagement(Vuelo vuelo)
        {
            _vuelo = vuelo;
        }
        public VueloManagement() { }
        #endregion


        public Vuelo createVuelo(Aeronave avion, Aerolinea company, DateTime fecha,Destinos destino)
        {
            //Creo y seteo el vuelo
            _vuelo = new Vuelo();
            _vuelo.company = company.nombre;
            _vuelo.destino = destino.ToString();
            _vuelo.partida = fecha;
            _vuelo.numero = getNumbreVuelo();
            _vuelo.nave = avion.modelo;
            _vuelo.estado = Estados.Creado;
            //Le pido al manejador que me retorne la capacidad
            iAeronave manage = new AeronaveManagement(avion);
            Capacidad c = manage.getCapacidad();
            //Creo lo asientos en un bucle según su capacidad
            List<Asiento> asientos = new List<Asiento>();
            for (int i = 0; i < c.turista; i++)
            {
                Asiento a = new Asiento();
                a.categoria = "Turista";
                a.estado = false;
                a.numero = i + 1;
                asientos.Add(a);
            }
            for (int i = 0; i < c.ejecutivo; i++)
            {
                Asiento a = new Asiento();
                a.categoria = "Ejecutivo";
                a.estado = false;
                a.numero = i + 1;
                asientos.Add(a);
            }
            _vuelo.asientos = asientos;
            //Persisto el nuevo vuelo
            VuelosData vdata = new VuelosData();
            vdata.agregar(_vuelo);
            return _vuelo;
        }


        //Metodo que genera aleatoriamente un string que utilizo para el numero de vuelo
        private string getNumbreVuelo()
        {
            int longitud = 7;
            const string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder vueloNum = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int indice = rnd.Next(alfabeto.Length);
                vueloNum.Append(alfabeto[indice]);
            }
            return vueloNum.ToString();
        }


    }


        
}
