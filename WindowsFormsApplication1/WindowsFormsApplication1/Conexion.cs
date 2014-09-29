using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace TP_DDS
{
    class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {

            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString ="Server=localhost\\SQLSERVER2008;Database=disenio_tp;User Id=gd;Password=gd2014;";
            try
            {
                conexion.Open();
                return conexion;
                
                // Insert code to process data.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falló la conexión con la base de datos");
                return null;
            }
            
        }

    }
}
