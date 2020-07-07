using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AeropuertosPoo.Entidades
{
    class mb814 : Aeronave
    {
        
        public mb814(string matri) : base(matri)
        {
            autonimia = 1000;//Supuesta autonomia
            modelo = "MB814";
            
        }

   
    }
}
