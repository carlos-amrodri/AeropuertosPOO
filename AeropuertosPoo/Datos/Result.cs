using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeropuertosPoo.Datos
{
    //Este es un objeto que sirve para realizar cualquier devolucion
    //El mismo es generico por lo cual toma la clase con la que se lo implementa
    //Puede devolver un solo objeto del type implementado, como un listado
    //como tambien puede retornar un error con string 
    public class Result <T>
    {
        public string error { get; set; }
        public List<T> listado { get; set; }
        public T objeto { get; set; }
    }
}
