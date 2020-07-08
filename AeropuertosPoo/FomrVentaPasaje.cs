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
    public partial class FomrVentaPasaje : Form
    {
        public FomrVentaPasaje()
        {
            InitializeComponent();
        }

        SingletonDatos datos = SingletonDatos.shared;

        private void FomrVentaPasaje_Load(object sender, EventArgs e)
        {
            comboDestino.DataSource = Enum.GetValues(typeof(Destinos));
        }

        private void comboDestino_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string desti = comboDestino.SelectedItem.ToString();
            var vuelos = datos.vuelos.Where(x => x.destino == desti).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = vuelos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Vuelo vueloselect = (Vuelo)dataGridView1.CurrentRow.DataBoundItem;
            var turista = vueloselect.asientos.Where(x => x.categoria == "Turista").ToList();
            for (int i = 0; i < turista.Count; i++)
            {
                var btn = new Button();
                btn.Width = 40;
                btn.Height = 40;
                Asiento asie = turista[i];
                btn.Text = asie.numero.ToString();
                if (asie.estado)
                {
                    btn.BackColor = Color.DarkRed;
                }
                else
                {
                    btn.BackColor = Color.DarkSeaGreen;
                }
                btn.Location = new Point(btn.Width * i + 4, 0);
                btn.Click += new EventHandler(btn_click);
                panelTurista.Controls.Add(btn);
            }
            var ejecutivo = vueloselect.asientos.Where(x => x.categoria == "Ejecutivo").ToList();
            for (int i = 0; i < ejecutivo.Count; i++)
            {
                var btn = new Button();
                btn.Width = 40;
                btn.Height = 40;
                Asiento asie = ejecutivo[i];
                btn.Text = asie.numero.ToString();
                if (asie.estado)
                {
                    btn.BackColor = Color.DarkRed;
                }
                else
                {
                    btn.BackColor = Color.CornflowerBlue;
                }
                btn.Location = new Point(btn.Width * i + 4, 0);
                btn.Click += new EventHandler(btnEjec_click);
                panel1.Controls.Add(btn);
            }
        }

        private void btn_click(object sender, System.EventArgs e)
        {
            var buton = (Button)sender;
            var value = buton.Text;
            MessageBox.Show("Soy el boton turista N :" + value);
        }

        private void btnEjec_click(object sender, System.EventArgs e)
        {
            var buton = (Button)sender;
            var value = buton.Text;
            MessageBox.Show("Soy el boton Ejecutivo N :" + value);
        }
    }
}
