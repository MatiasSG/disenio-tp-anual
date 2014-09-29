using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Security.Cryptography;

namespace TP_DDS
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void alta_Load(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {
            textNombre.BackColor = Color.White;
        }

        private void labelApellido_Click(object sender, EventArgs e)
        {

        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {
            textApellido.BackColor = Color.White;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fechaPick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textContra_TextChanged(object sender, EventArgs e)
        {
            textContra.BackColor = Color.White;
        }

        private bool estaVaciaSinEspacio(string valor)
        {
            return (string.IsNullOrEmpty(valor) | string.IsNullOrWhiteSpace(valor));
        }

        private void resaltarContenedorIdUser()
        {
            textUser.Clear();
            textUser.Focus();
            textUser.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(todosLosTextEstanCompletos())
            {
                try
                {
                    SqlConnection miConexion = Conexion.ObtenerConexion();

                    //Comando donde cargo el store procedure para la validación del usuario
                    SqlCommand comando = new SqlCommand("TP_DISENIO.alta", miConexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@nombre", textNombre.Text);
                    comando.Parameters.AddWithValue("@apellido", textApellido.Text);
                    comando.Parameters.AddWithValue("@fecha_nac", fechaPick.Value);
                    comando.Parameters.AddWithValue("@id_user", textUser.Text);
                    comando.Parameters.AddWithValue("@pass", textContra.Text);

                    //Logica para el manejo del parámetro de retorno
                    SqlParameter parametroRetorno = new SqlParameter();
                    parametroRetorno.ParameterName = "@retorno";
                    parametroRetorno.DbType = DbType.Int32;
                    parametroRetorno.Direction = ParameterDirection.Output;
                    //Agrego el parametro
                    comando.Parameters.Add(parametroRetorno);

                    //Ejecutor el comando SP
                    SqlDataReader reader = comando.ExecuteReader();

                    //Obtengo el valor del parametro de retorno del SP
                    string resultadoEjecucion = comando.Parameters["@retorno"].Value.ToString();

                    //Cierro la ejecución
                    miConexion.Close();


                    //Evaluo el resultado de la ejecución
                    //Resultado=1 => Alta exitosa
                    //Resultado=2 => Usuario existente

                    switch (resultadoEjecucion)
                    {
                        case "1":
                            MessageBox.Show("Nombre de usuario existente, ingrese otro.", "Usuario existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            resaltarContenedorIdUser();
                            break;

                        case "2":
                            MessageBox.Show("El usuario ha sido dado de alta exitosamente", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            break;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo realizar el login. Cierre la aplicación y vuelva a intentarlo");
                }

            }
            
             



        }

        private bool todosLosTextEstanCompletos()
        {
            if(textNombre.Text!=""|| textApellido.Text!=""||textUser.Text!=""||textContra.Text!="")
            {
                return true;
            }
            else
            {
                verificarYPonerAlerta(textNombre);
                verificarYPonerAlerta(textApellido);
                verificarYPonerAlerta(textUser);
                verificarYPonerAlerta(textContra);
                MessageBox.Show("Complete los campos resaltados", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void verificarYPonerAlerta(TextBox unText)
        {
            if(unText.Text=="")
            {
                unText.BackColor = Color.Red;
            }
        }
        private void btnAmigos_Click(object sender, EventArgs e)
        {
            this.Hide();
            agregarunAmigo frmaAmigos = new agregarunAmigo();
            frmaAmigos.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {
            textUser.BackColor = Color.White;
        }
    }
}
