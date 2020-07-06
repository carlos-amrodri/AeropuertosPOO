using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AeropuertosPoo.Entidades;
using System.IO;
using Newtonsoft.Json;
using System.Reflection;
using System.Xml.Serialization;  

namespace AeropuertosPoo.Datos
{
    class AerolineasData : iDatos<Aerolinea>
    {
        //Path absoluto base donde se persiste el json creado
        const string urlBase = @"C:\Users\Carito\documents\visual studio 2015\Projects\AeropuertosPoo\AeropuertosPoo\Datos\";


        public void agregar(Aerolinea myObject)
        {
            throw new NotImplementedException();
        }

        public Result<Aerolinea> getResultado(string path)
        {
            string url = urlBase + "Aerolineas.json";
            Result<Aerolinea> result = new Result<Aerolinea>();
            StreamReader lector = new StreamReader(url);
            try
            {
                
                string json = lector.ReadToEnd();
                result.listado = JsonConvert.DeserializeObject<List<Aerolinea>>(json);
            }
            catch (Exception e)
            {
                result.error = e.ToString();
            }
            finally
            {
                lector.Close();
            }
            //Nota!! Encoder algunos ejemplos puede que encuentren el uso del lector de esta menera
            //using (StreamReader lector = new StreamReader(url))
            //{
            //    string json = lector.ReadToEnd();
            //    List<Aerolinea> lis = JsonConvert.DeserializeObject<List<Aerolinea>>(json);
            //    var t = 8;
            //}
            //En este caso, using sirve para especificar bloques de código en los que se van a utilizar recursos que deben ser liberados obligatoriamente al finalizar
            return result;
        }

        public List<Aerolinea> listado(string path)
        {
            throw new NotImplementedException();
        }





        //Este metodo es el que utilicé para generar el archivo json inicial
        //Lo dejo solo de muestra
        public void generar()
        {
            //Aerolineas ***************
            Aerolinea a1 = new Aerolinea("Lan");
            Aerolinea a2 = new Aerolinea("Gool");
            Aerolinea a3 = new Aerolinea("Portela");
            //Aeronaves ****************
            Aeronave n1 = new nave1114("JGJK75");
            Aeronave n2 = new nave1114("gy64ghkf");
            Aeronave n3 = new nave1114("GT67KOG5");

            Aeronave n4 = new mb1418("GHvb586756DF");
            Aeronave n5 = new mb1418("JH67GV765");
            Aeronave n6 = new mb1418("HYU75LG");

            Aeronave n7 = new mb814("HG675JKLÑH7");
            Aeronave n8 = new mb814("GJH7JKB7");
            //Agreo naves  a compañias ***************
            a1.addNave(n1);
            a1.addNave(n4);
            a1.addNave(n5);
            a2.addNave(n2);
            a2.addNave(n3);
            a3.addNave(n6);
            a3.addNave(n7);
            a3.addNave(n8);
            //Listado de objetos
            List<Aerolinea> listado = new List<Aerolinea>();
            listado.Add(a1);
            listado.Add(a2);
            listado.Add(a3);
            //Genero la url con la base mas la del archivo
            string url = urlBase + "Aerolineas.json";
            //Parseo a json y guardo 
            string json = JsonConvert.SerializeObject(listado);
            File.WriteAllText(url, json);
        }
    }
}
