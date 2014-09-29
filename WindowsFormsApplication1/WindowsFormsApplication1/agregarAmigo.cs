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
       
    public partial class agregarunAmigo : Form
    {

        private Partido _unPartido;
        private Jugador _unJugador;
        public int contador=0;
  



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

        public agregarunAmigo()
        {
            InitializeComponent();
        }

      
        
       
   

        private void agregarTodosMenosElmismo (Jugador unJugador)
        {
            if(unJugador.user!=JugadorLogueado.Instance.user)
            {
                listJugadores.Items.Add(unJugador.user);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
         
        }

 
        private void listJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





        private void textAmigo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void listAmigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAgregarAmigo.Enabled = true;
        }
    }
}
