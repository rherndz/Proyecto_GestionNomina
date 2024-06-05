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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginApp
{
    public partial class Login_form : Form
    {

        //Enlace a la clase Conexion_sql
        SqlConnection conexion = new SqlConnection("server = DESKTOP-PFTDRUB; dataBase = bsd_SistemaOrion; integrated security = true");

        public Login_form()
        {
            InitializeComponent();

            checkBox_viewpass.CheckedChanged += (s, e) => {
                txtbox_password.PasswordChar = checkBox_viewpass.Checked ? '\0' : '*';
            };
        }


        //Extraxion del tipo de usuario para manejar el boton regresar con su tipo
        public static class TipoUsuarioGlobal
        {
            public static string TipoUsuario { get; set; }
        }



        bool valueVacio_username = false;

        bool valueVacio_password = false;

        private void txtbox_username_TextChanged(object sender, EventArgs e)
        {

            // Validacion del estado del txtBox_username

            if (string.IsNullOrEmpty(txtbox_username.Text))
            {
                valueVacio_username = true;
                errorProvider_txtUser.SetError(txtbox_username, "ADVERTENCIA: La casilla esta vacia");
            }
            else
            {
                valueVacio_username = false;

                // Validacion de letras y numeros
                if (!txtbox_username.Text.All(char.IsLetterOrDigit))
                {
                    errorProvider_txtUser.SetError(txtbox_username, "ERROR: Usuario solo puede contener letras y numeros");
                }
                else if (txtbox_username.Text.Any(char.IsUpper))
                {
                    // Validar que no contenga mayusculas
                    errorProvider_txtUser.SetError(txtbox_username, "ERROR: Usuario no puede contener mayusculas");
                }
                else
                {
                    // Si todo es correcto, no se mostrara el error
                    errorProvider_txtUser.SetError(txtbox_username, string.Empty);
                }
            }

        }

        private void txtbox_password_TextChanged(object sender, EventArgs e)
        {

            // Validacion del estado del txtBox_password

            if (string.IsNullOrEmpty(txtbox_password.Text))
            {
                valueVacio_password = true;
                errorProvider_txtPass.SetError(txtbox_password, "ADVERTENCIA: La casilla esta vacia");
            }
            else
            {
                valueVacio_password = false;

                // Validacion de caracteres permitidos
                if (!txtbox_password.Text.All(char.IsLetterOrDigit))
                {
                    errorProvider_txtPass.SetError(txtbox_password, "ERROR: Contraseña solo puede contener letras y numeros.");
                }
                else
                {
                    // Si todo es correcto, no se mostrara el error
                    errorProvider_txtPass.SetError(txtbox_password, string.Empty);
                }
            }
        }

        private void button_loginpass_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string usuario = txtbox_username.Text;
            string contrasena = txtbox_password.Text;

            bool valueVacio_username = string.IsNullOrEmpty(usuario);
            bool valueVacio_password = string.IsNullOrEmpty(contrasena);

            // Validar que los campos txtBox_username y txtBox_password 
            if (!valueVacio_username && !valueVacio_password)
            {
                try
                {
                    // Consulta a SQL SERVER (Seleccionar de tabla usuario, Tipo de usuario, Usuario y contraseña)
                    string query = "SELECT usuario, tipo_usuario FROM Usuarios WHERE usuario = @usuario AND contrasena = @contrasena";
                    
                    SqlCommand cmd_sql = new SqlCommand(query, conexion);
                    
                    cmd_sql.Parameters.AddWithValue("@usuario", usuario);
                    cmd_sql.Parameters.AddWithValue("@contrasena", contrasena);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd_sql);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    //Validar si en la tabla existe un registro
                    if (dt.Rows.Count == 1)
                    {
                        this.Hide();

                        //variable que extraera el tipo de usaurio
                        TipoUsuarioGlobal.TipoUsuario = dt.Rows[0]["tipo_usuario"].ToString();

                        // Verificar el tipo de usuario y abrir la ventana correspondiente
                        string tipoUsuario = dt.Rows[0]["tipo_usuario"].ToString();
                        string nombreUsuario = dt.Rows[0]["usuario"].ToString();

                        if (tipoUsuario == "empleado")
                        {   

                            Inicio_Dashboard frmEmpleado = new Inicio_Dashboard();

                            frmEmpleado.Show();

                        }
                        else if (tipoUsuario == "administracion")
                        {   
                            Inicio_administracion frmAdministracion = new Inicio_administracion();

                            frmAdministracion.Show();

                        }
                        else if (tipoUsuario == "admin")
                        {

                            Inicio_admin frmAdmin = new Inicio_admin();

                            frmAdmin.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o Contraseña Incorrectos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
            else
            {
                // Mostrar mensajes si los campos estan vacios
                if (valueVacio_username && valueVacio_password)
                {
                    MessageBox.Show("Usuario y contraseña estan vacios");
                }
                else if (valueVacio_username)
                {
                    MessageBox.Show("La casilla usuario esta vacia");
                }
                else if (valueVacio_password)
                {
                    MessageBox.Show("La casilla contraseña esta vacia");
                }
            }

            conexion.Close();
        }

        private void checkBox_viewpass_CheckedChanged(object sender, EventArgs e)
        {
            txtbox_password.PasswordChar = checkBox_viewpass.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Cualquier consulta, duda o error comunicarse a correo electronico: soporte_tecnico@gmail.com ");
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
