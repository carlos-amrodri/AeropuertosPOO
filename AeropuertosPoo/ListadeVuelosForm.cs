using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AeropuertosPoo.Entidades;

namespace AeropuertosPoo
{
    public partial class ListadeVuelosForm : Form, iObsVuelos
    {
        public ListadeVuelosForm()
        {
            InitializeComponent();
        }

        public List<Vuelo> listaVuelos { get; set; }

        private void ListadeVuelosForm_Load(object sender, EventArgs e)
        {
            gridVuelos.DataSource = listaVuelos;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
        //Metodo de la interfaz que es notificado cuando actualiza
        public void actualizar(Vuelo vuelo)
        {
           
            gridVuelos.DataSource = null;
            gridVuelos.DataSource = listaVuelos;
        }
    }
}
