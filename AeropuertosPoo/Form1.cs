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

namespace AeropuertosPoo
{
    public partial class Aeropuerto : Form
    {
        public Aeropuerto()
        {
            InitializeComponent();
        }

        SingletonDatos datos;

        private void Form1_Load(object sender, EventArgs e)
        {
            datos = SingletonDatos.shared;//Utilizo la instancia del singleton
            AerolineasData aerolineas = new AerolineasData();
            //  aerolineas.generar();
            //LLamo al metodo que me retorna un resultado con la lista de compañias
            var result = aerolineas.getResultado("Aerolineas.json");
            if (result.error != null)
            {
                //sim paso por aca es porque ocurrio un error
                MessageBox.Show("Ops! :(" + result.error);
                return;
            }
            //Si llego hasta aca es porque tiene datos
            datos.aerolineas = result.listado;

            //Prueba
            datos.vuelos = new List<Entidades.Vuelo>();
        }

        private void crearVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearVuelo windCreatVuelo = new CrearVuelo();
            windCreatVuelo.MdiParent = this;
            windCreatVuelo.Show();
        }
    }
}
