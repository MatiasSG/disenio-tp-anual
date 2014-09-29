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
    public partial class Baja : Form
    {
        private Partido _partido;
        private Jugador _jugadorReemplazante;
        private string _tipoEliminado;


    

    
        public Baja()
        {
            InitializeComponent();
        }

        private void Baja_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'disenio_tpDataSet1.Inscripciones' Puede moverla o quitarla según sea necesario.
            this.inscripcionesTableAdapter.Fill(this.disenio_tpDataSet1.Inscripciones);
            // TODO: esta línea de código carga datos en la tabla 'disenio_tpDataSet.Partidos' Puede moverla o quitarla según sea necesario.
            this.partidosTableAdapter.Fill(this.disenio_tpDataSet.Partidos);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void eliminarDeListas()
        {

             
        }
      


      

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
