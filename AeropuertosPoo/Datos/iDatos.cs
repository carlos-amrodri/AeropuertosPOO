using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AeropuertosPoo.Datos;

namespace AeropuertosPoo
{
    public interface iDatos<T>
    {
        List<T> listado(string path);
        Result<T> getResultado(string path);
        void agregar(T myObject);
    }
}
