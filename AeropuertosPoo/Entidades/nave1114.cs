using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AeropuertosPoo.Entidades
{
    public class nave1114 : Aeronave
    {
        public nave1114(string matri) : base(matri)
        {
            autonimia = 1500;//Supuesta autonomia
            modelo = "MB114";
           
        }

    
    }
}
