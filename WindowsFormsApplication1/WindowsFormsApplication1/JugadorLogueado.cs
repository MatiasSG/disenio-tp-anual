
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TP_DDS
{
    public sealed class JugadorLogueado : Jugador
    {
        private static JugadorLogueado instance = null;
        private JugadorLogueado() { }
        public static JugadorLogueado Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JugadorLogueado();
                }
                return instance;
            }
        }
    }
}