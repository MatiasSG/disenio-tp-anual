using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace TP_DDS
{
    public partial class inscripciones : Form
    {
        private int _check = 1;
        private Partido _partido;
        private int _primerVez;

        public int primeraVez
        {
            get { return _primerVez; }
            set { _primerVez = value; }
        }

        public Partido partido
        {
            get { return _partido; }
            set { _partido = value; }
        }

        public int check
        {
            get { return _check; }
            set { _check = value; }

        }
        //private DateTime _FechaYHora;

        private static Mutex mut = new Mutex();
  
        public inscripciones()
        {
            InitializeComponent();
        }

        private void limpiarListBox ()
        {
           
            
        }
        private void inscripciones_Load(object sender, EventArgs e)
        {
            
          
        }


      
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void listPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
        private void cargarEstandar()
        {
          
            
        }
        private void cargarSolidario()
        {

         
        }
        private void cargarCondicional()
        {
          
        }



        private void listTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnIns.Enabled = true;
        }
        private void ponerEnabled()
        {
            btnIns.Enabled = true;
            listTipo.Enabled = true;
        }
        private void listPartidos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           



        }

       
        
        private void btnIns_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listJugadores.ClearSelected();
            listPartidos.ClearSelected();
            this.Close();
        }
    }
}
