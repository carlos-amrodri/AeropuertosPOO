using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AeropuertosPoo.Entidades;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;


namespace AeropuertosPoo.Datos
{
    public class AerolineasXml : iDatos<Aerolinea>
    {

        public AerolineasXml()
        {
            loadjson();
        }



        private void loadjson()
        {
            string path = @"C:\Users\Carito\documents\visual studio 2015\Projects\AeropuertosPoo\AeropuertosPoo\Datos\Aerolineas.json";
  
            Aerolinea a1 = new Aerolinea("Lan");
            Aerolinea A2 = new Aerolinea("Gool");
            Aerolinea a3 = new Aerolinea("Portela");


            //Aeronave n1 = new nave1114("JGJK75", 45);
            //Aeronave n2 = new nave1114("gy64ghkf", 45);
            //Aeronave n3 = new nave1114("GT67KOG5", 45);

            //Aeronave n4 = new mb1418("GHvb586756DF", 89);
            //Aeronave n5 = new mb1418("JH67GV765", 89);
            //Aeronave n6 = new mb1418("HYU75LG", 89);

            //Aeronave n7 = new mb814("HG675JKLÑH7", 90);
            //Aeronave n8 = new mb814("GJH7JKB7", 90);

            //a1.addNave(n1);
            //a1.addNave(n4);
            //a1.addNave(n5);
            //A2.addNave(n2);
            //A2.addNave(n3);
            //a3.addNave(n6);
            //a3.addNave(n7);
            //a3.addNave(n8);

            List<Aerolinea> listado = new List<Aerolinea>();
            listado.Add(a1);
            listado.Add(A2);
            listado.Add(a3);

            string json = JsonConvert.SerializeObject(listado);
            File.WriteAllText(path, json);
         
        }

        private void cargar()
        {
            //Path donde se encuentra el archivo
            string path = @"C:\Users\Carito\documents\visual studio 2015\Projects\AeropuertosPoo\AeropuertosPoo\Datos\Companias.xml";
            //Objeto que maneja el documento xml
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(path);//Metodo del objeto para cargar el documento
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
           //Recorro el documento y obtengo los nodos secundarios en la variable nodo
            foreach(XmlNode nodo in doc.DocumentElement.ChildNodes)
            {
                //Obtengo el nomre e inicializo el objeto compañia
                string name = nodo.Attributes["name"].Value;
                Aerolinea a1 = new Aerolinea(name);
                if (nodo.HasChildNodes)
                { //Si el nodo tiene hijos
                    for(int i = 0; i < nodo.ChildNodes.Count; i++)
                    {
                        var hijo = nodo.ChildNodes[i].ChildNodes; //Obtengo el nodo hijo
                        
                        foreach (XmlNode nodeb in hijo)
                        {
                            var prop = nodeb.Name;
                            var valor = nodeb.InnerText;
                            switch (prop)
                            {
                                case "model":
                                    break;
                                case "matricula":
                                    break;
                                case "capacidad":
                                    break;
                                default:break;
                            }
                            Console.WriteLine(nodeb);
                        }
                    }
                }
            }
        }


        private void desserializador()
        {
            //Path donde se encuentra el archivo
            string path = @"C:\Users\Carito\documents\visual studio 2015\Projects\AeropuertosPoo\AeropuertosPoo\Datos\Companias.xml";
         

            try
            {
                StreamReader lector = new StreamReader(path);
                XmlSerializer ser = new XmlSerializer(typeof(Aerolinea));
                var  a1 = ser.Deserialize(lector);
                var p = 9;

            }catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }



        public void agregar(Aerolinea myObject)
        {
            throw new NotImplementedException();
        }  

        public List<Aerolinea> listado()
        {
            throw new NotImplementedException();
        }

        public List<Aerolinea> listado(string path)
        {
            throw new NotImplementedException();
        }

        public Result<Aerolinea> getResultado(string path)
        {
            throw new NotImplementedException();
        }
    }
}
