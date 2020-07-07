using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AeropuertosPoo.Entidades;
using Newtonsoft.Json;
using System.IO;

namespace AeropuertosPoo.Datos
{
    public class VuelosData : iDatos<Vuelo>
    {
        const string urlBase = @"C:\Users\Carito\documents\visual studio 2015\Projects\AeropuertosPoo\AeropuertosPoo\Datos\";

        public void agregar(Vuelo myObject)
        {
            //De la instancia general de datos le agrego el vuelo
            SingletonDatos datos = SingletonDatos.shared;
            datos.vuelos.Add(myObject);
            //LLamo al método que persiste los vuelos
            var vuelos = datos.vuelos;
            salvar(vuelos);
        }

        public Result<Vuelo> getResultado(string path)
        {
            throw new NotImplementedException();
        }

        public List<Vuelo> listado(string path)
        {
            throw new NotImplementedException();
        }

       private void salvar(List<Vuelo> list)
        {
            //Genero la url con la base mas la del archivo
            string url = urlBase + "Vuelos.json";
            //Parseo a json y guardo 
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText(url, json);
        }
    }
}
