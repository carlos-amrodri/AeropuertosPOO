using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeropuertosPoo.Entidades
{
    public interface iSujetoVuelo
    {
        void agregar(iObsVuelos obs);
        void notificar();
    }
}
