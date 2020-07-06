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
        [JsonProperty("nombre")]
        public string nombre { get; set; }
        [JsonProperty("aeronaveList")]
        public List<Aeronave> aeronaveList { get; set; }
        

    
        public Aerolinea() {
            this.aeronaveList = new List<Aeronave>();
        }


        #region Metodos
        public Aerolinea(string _nombre)
        {
            this.nombre = _nombre;
            this.aeronaveList = new List<Aeronave>();
        }
 

        
        public void addNave(Aeronave nave)
        {
            this.aeronaveList.Add(nave);
        }
        #endregion /Metodos
    }
}
