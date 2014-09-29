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
    public partial class menuAdmin : Form
    {
        
        public menuAdmin()
        {
             InitializeComponent();
        }
        
        private void menuAdmin_Load(object sender, EventArgs e)
        {
           textNombre.Focus();
        }


        private bool chequearVacios ()
        {
            if (nombreText.Text==String.Empty)
             {
                 return true;
             }
            return false;
        }
        

        private void textNombre_TextChanged(object sender, EventArgs e)
        {
            textNombre.BackColor = Color.White;
        }

        private void menuAdmin_Load_1(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
             //TODO  verificar si los campos no son completados
            
           
           
        }

        private void nombreText_TextChanged(object sender, EventArgs e)
        {
            nombreText.BackColor = Color.White;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }



    }
}
