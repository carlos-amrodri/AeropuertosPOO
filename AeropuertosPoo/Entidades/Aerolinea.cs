using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AeropuertosPoo.Entidades
{
  
    public class Aerolinea
    {
      
        public string nombre { get; set; }
        public List<Aeronave> aeronaveList { get; set; }
        public List<Vuelo> vuelos { get; set; }



        public Aerolinea() {
            this.aeronaveList = new List<Aeronave>();
        }
        public Aerolinea(string _nombre)
        {
            this.nombre = _nombre;
            this.aeronaveList = new List<Aeronave>();
        }


        #region Metodos
        public void addNave(Aeronave nave)
        {
            this.aeronaveList.Add(nave);
        }
        public void addVuelo(Vuelo vuelo)
        {
            this.vuelos.Add(vuelo);
        }
        #endregion /Metodos
    }
}
