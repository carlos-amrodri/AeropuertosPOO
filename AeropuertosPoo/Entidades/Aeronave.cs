using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace AeropuertosPoo.Entidades
{
    //Esta podria tratarse de una clase abstracta 
    //Pero la clase que lo persiste como json no podria inicializarlo, por tal motivo esta como clase publica
    //y tiene un cosntructor publico
    public  class Aeronave
    {
     
        public string matricula { get; set; }
        public string modelo { get; set; }
        public int autonimia { get; set; }
       

        //Constuctores
        public Aeronave(string matri)
        {
            this.matricula = matri;
            
        }
        public Aeronave() { }

        //Metodo que retorna la autonomia
        public int getAutonomia()
        {
            return this.autonimia;
        }

        
        



    }
}
