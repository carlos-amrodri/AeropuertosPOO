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
    public partial class Aeropuerto : Form
    {
        public Aeropuerto()
        {
            InitializeComponent();
        }

        SingletonDatos datos;
        ListadeVuelosForm vuelosform;

        private void Form1_Load(object sender, EventArgs e)
        {
            datos = SingletonDatos.shared;//Utilizo la instancia del singleton
            AerolineasData aerolineas = new AerolineasData();

            //Cuendo creo por primera vez la app el json no existe, lo cual lo creo con la linea comentada abajo
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

            //NOTA: La primera vez vuelos.json no existe !! y aca llamo al metodo que no tiene try catch
            //Cargo los vuelos

            VuelosData vdata = new VuelosData();
            var listavuelos = vdata.listado("Vuelos.json");
            datos.vuelos = listavuelos;
            mostarVuelos();

        }

        private void crearVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearVuelo windCreatVuelo = new CrearVuelo();
            windCreatVuelo.agregar(this.vuelosform);
            windCreatVuelo.MdiParent = this;
            windCreatVuelo.Show();
        }

        #region Métodos
        private void mostarVuelos()
        {
            vuelosform = new ListadeVuelosForm();
            vuelosform.listaVuelos = datos.vuelos;
            vuelosform.MdiParent = this;
            vuelosform.Show();
        }
        #endregion

        private void verVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostarVuelos();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FomrVentaPasaje formventa = new FomrVentaPasaje();
            formventa.MdiParent = this;
            formventa.Show();
        }
    }
}
