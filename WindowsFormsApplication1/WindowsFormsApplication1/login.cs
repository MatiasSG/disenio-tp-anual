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
    public partial class login : Form
    {
          

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool estaVacio(string valor)
        {
            if(string.IsNullOrEmpty(valor)==true)
            {
                return true;
            }
            return false;
        }
        private bool chequeoText()
        {
            bool resultado = false;
            resultado =resultado|string.IsNullOrEmpty(textUsuario.Text);
            if(resultado==true)
            {
                textUsuario.BackColor = Color.Red;
            }
            resultado = false;
            resultado = resultado | string.IsNullOrEmpty(textContra.Text);
            if(resultado==true)
            {
                textContra.BackColor = Color.Red;
            }
            return resultado;
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
           
            if (textUsuario.Text != "" || textContra.Text != "")
            {

                try
                {
                    SqlConnection myConnection = Conexion.ObtenerConexion();

                    // Comando donde cargo el store procedure para la validacion del usuario
                    SqlCommand comando = new SqlCommand("TP_DISENIO.verificarUsuario", myConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_user", textUsuario.Text);
                    comando.Parameters.AddWithValue("@pass",textContra.Text);

                    //Logica para el manejo de un parametro del tipo OUTPUT
                    SqlParameter parametroRetorno = new SqlParameter();
                    parametroRetorno.ParameterName = "@retorno";
                    parametroRetorno.DbType = DbType.Int32;
                    parametroRetorno.Direction = ParameterDirection.Output;
                    //Agrego dicho parametro
                    comando.Parameters.Add(parametroRetorno);


                    //Ejecuto el comando SP
                    SqlDataReader reader = comando.ExecuteReader();

                    //Obtengo el valor del parametro de tipo OUTPUT del SP
                    string resultadoEjecucion = comando.Parameters["@retorno"].Value.ToString();

                    //Cierro la conexion
                    myConnection.Close();

                    //Evaluo el resultado de la ejecucion del SP e informo el resultado
                    //Resultado = 1 ==> No existe el usuario
                    //Resultado = 2 ==> Contraseña incorrecta                    
                    //Resultado = 3 ==> Login exitoso
                    switch(resultadoEjecucion)
                    {
                        case "1":
                            this.manejarText(textUsuario,"Usuario Inexistente","Error usuario" );
                        break;
                        
                        case "2":
                            this.manejarText(textContra, "Contraseña Incorrecta", "Error contraseña");
                        break;

                        case "3":
                            JugadorLogueado.Instance.user=textUsuario.Text;
                            JugadorLogueado.Instance.contra = textContra.Text;
                            //Mostrar el menu
                        break;

                    }
                    
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo realizar el login. Cierre la aplicación y vuelva a intentarlo");
                }
            }

            else
            {
                this.chequeoTexts();
            }
        }


        private void chequeoTexts()
        {
            if(textUsuario.Text=="" && textContra.Text=="")
            {
                MessageBox.Show("Ingrese un usuario y una contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textUsuario.Focus();
                textUsuario.BackColor=Color.Red;
                textContra.BackColor=Color.Red;
            }

        }
        private void manejarText(TextBox unTextBox,string cuerpo,string cabecera)
        {
            unTextBox.BackColor = Color.Red;
            MessageBox.Show(cuerpo, cabecera, MessageBoxButtons.OK, MessageBoxIcon.Error);
            unTextBox.Focus();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Alta frmAlta = new Alta();
            this.Hide();
            frmAlta.Show();
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
            textUsuario.BackColor = Color.White;
        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {
            textContra.BackColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
