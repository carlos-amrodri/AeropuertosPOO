using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AeropuertosPoo.Datos;
using AeropuertosPoo.Entidades;

namespace AeropuertosPoo
{
    public partial class CrearVuelo : Form, iSujetoVuelo
    {
        public CrearVuelo()
        {
            InitializeComponent();
        }

        SingletonDatos datos;
        List<iObsVuelos> observadoresVuelo = new List<iObsVuelos>();
        Vuelo vueloNuevo;
        

        private void CrearVuelo_Load(object sender, EventArgs e)
        {
            datos = SingletonDatos.shared;//Utilizo la instancia del singleton
            loadAerolineas();
            //Cargo los destino con el enumerado de destinos
            comboDestino.DataSource = Enum.GetValues(typeof(Destinos));
        }


        #region Metodos
        private void loadAerolineas()
        {
            this.cmboAerolinea.DataSource = datos.aerolineas;
            this.cmboAerolinea.DisplayMember = "nombre";
        }
        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmboAerolinea_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmboAerolinea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Seleccion de compañia
            Aerolinea compa = (Aerolinea)cmboAerolinea.SelectedItem;
            gridAviones.DataSource = null;
            gridAviones.DataSource = compa.aeronaveList;
            //Utilizo LinQ para no repetir 
            var dupli = compa.aeronaveList.GroupBy(c => c.modelo)
                .Select(g => g.First()).ToList();
            List<Aeronave> aviones = dupli;
            comboAvion.DataSource = null;
            comboAvion.DataSource = aviones;
            comboAvion.DisplayMember = "modelo";
            comboAvion.Enabled = true;
        }

        private void comboAvion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Aeronave nave = (Aeronave) comboAvion.SelectedItem;
            iAeronave inave = new AeronaveManagement(nave);
            Capacidad cap = inave.getCapacidad();
            lblturista.Text ="Turista: " + cap.turista.ToString();
            lblejecutivo.Text ="Ejecutivo: " + cap.ejecutivo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VueloManagement vuelmang = new VueloManagement();
            var avion =(Aeronave) comboAvion.SelectedItem;
            var aerolinea = (Aerolinea)cmboAerolinea.SelectedItem;
            var fecha = dateTimePicker1.Value;
            var desti =(Destinos) comboDestino.SelectedItem;
            vueloNuevo = vuelmang.createVuelo(avion, aerolinea, fecha, desti);
            notificar();
        }

        public void agregar(iObsVuelos obs)
        {
            this.observadoresVuelo.Add(obs);
        }

        public void notificar()
        {
            foreach(iObsVuelos obs in observadoresVuelo)
            {
                obs.actualizar(vueloNuevo);
            }
        }
    }
}


