using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DDS
{
       
    public partial class recomendacion : Form
    {
        private Partido _unPartido;
        private Jugador _unJugador;

        public Partido unPartido
        {
            get { return _unPartido; }
            set { _unPartido = value; }
        }

        public Jugador unJugador
        {
            get { return _unJugador; }
            set { _unJugador = value; }
        }

        public recomendacion()
        {
            InitializeComponent();
        }

                private void agregarUnPartido(Partido unPartido)
        {
            if (listPartidos.Items.Contains(unPartido.nombre) == false)
            {

                listPartidos.Items.Add(unPartido.nombre);
            }
        }
   
     
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            listAmigos.Enabled = true;
            this.unJugador = this.buscarJugador(listJugadores.SelectedItem.ToString());
            if(this.unJugador.amigos.Count>0)
            {
                this.unJugador.amigos.ForEach(unAmigo => listAmigos.Items.Add(unAmigo));
            }
            else
            {
                MessageBox.Show("El jugador seleccionado no tienen amigos para recomendar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
           
        }

        private Jugador buscarJugador(string nombre)
        {
            return this.unPartido.jugadores.Find(unJugador => unJugador.nombre == nombre);
        }

        private void listAmigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRecomendar.Enabled = true;
        }
    }
}
