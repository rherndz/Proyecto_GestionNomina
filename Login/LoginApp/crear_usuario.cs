using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LoginApp.Login_form;

namespace LoginApp
{
    public partial class formulario_CrearUsuario : Form
    {
        public formulario_CrearUsuario()
        {
            InitializeComponent();

            comboBox_tipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox_IdEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //Enlace a la clase Conexion_sql
        SqlConnection conexion = new SqlConnection("server = DESKTOP-PFTDRUB; dataBase = bsd_SistemaOrion; integrated security = true");

        bool valueVacio_username = false;

        bool valueVacio_password = false;

        private void txtbox_idUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_usuario_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_usuario.Text))
            {
                valueVacio_username = true;
                errorProviderUsuario.SetError(txtbox_usuario, "ADVERTENCIA: La casilla esta vacia");
            }
            else
            {
                valueVacio_username = false;

                // Validacion de letras y numeros
                if (!txtbox_usuario.Text.All(char.IsLetterOrDigit))
                {
                    errorProviderUsuario.SetError(txtbox_usuario, "ERROR: Usuario solo puede contener letras y numeros");
                }
                else if (txtbox_usuario.Text.Any(char.IsUpper))
                {
                    // Validar que no contenga mayusculas
                    errorProviderUsuario.SetError(txtbox_usuario, "ERROR: Usuario no puede contener mayusculas");
                }
                else
                {
                    // Si todo es correcto, no se mostrara el error
                    errorProviderUsuario.SetError(txtbox_usuario, string.Empty);
                }
            }
        }

        private void txtbox_contrasena_TextChanged(object sender, EventArgs e)
        {

            // Validacion del estado del txtBox_password

            if (string.IsNullOrEmpty(txtbox_contrasena.Text))
            {
                valueVacio_password = true;
                errorProviderContrasena.SetError(txtbox_contrasena, "ADVERTENCIA: La casilla esta vacia");
            }
            else
            {
                valueVacio_password = false;

                // Validacion de caracteres permitidos
                if (!txtbox_contrasena.Text.All(char.IsLetterOrDigit))
                {
                    errorProviderContrasena.SetError(txtbox_contrasena, "ERROR: Contraseña solo puede contener letras y numeros.");
                }
                else
                {
                    // Si todo es correcto, no se mostrara el error
                    errorProviderContrasena.SetError(txtbox_contrasena, string.Empty);
                }
            }


        }

        //button crear usuario
        private void btn_crear_Click(object sender, EventArgs e)
        {
            string usuario = txtbox_usuario.Text;
            string contrasena = txtbox_contrasena.Text;
            string tipoUsuario = comboBox_tipoUsuario.SelectedItem?.ToString();
            int idEmpleado;
            int idUsuario;

            // Validar los campos y convertir los ID a enteros
            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(contrasena) && !string.IsNullOrEmpty(tipoUsuario)
                && comboBox_IdEmpleados.SelectedItem != null && int.TryParse(comboBox_IdEmpleados.SelectedItem.ToString(), out idEmpleado)
                && int.TryParse(txtbox_idUsuario.Text, out idUsuario))
            {
                // Insertar nuevo usuario en la base de datos
                string connectionString = "server=DESKTOP-PFTDRUB;database=bsd_SistemaOrion;integrated security=true";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    try
                    {
                        conexion.Open();
                        string agregarUsuario = "INSERT INTO Usuarios (id_usuario, usuario, contrasena, tipo_usuario, id_empleado) VALUES (@idUsuario, @usuario, @contrasena, @tipoUsuario, @idEmpleado)";
                        SqlCommand cmd = new SqlCommand(agregarUsuario, conexion);

                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);
                        cmd.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
                        cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("El usuario se creó exitosamente.");
                            LimpiarCampos();
                            CargarUsuariosEnGrid(); // Actualizar el DataGridView después de crear un nuevo usuario
                        }
                        else
                        {
                            MessageBox.Show("Error al crear usuario.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al intentar crear usuario: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos y asegúrese de que los ID sean números válidos.");
            }
        }

        //button limpiar Campos
        private void btn_limpiar_Click(object sender, EventArgs e)
        {

            LimpiarCampos();

        }

        //Metodo para limpiarCampos
        private void LimpiarCampos()
        {
            txtbox_idUsuario.Clear();
            txtbox_usuario.Clear();
            txtbox_contrasena.Clear();
            comboBox_tipoUsuario.SelectedIndex = -1;
            comboBox_IdEmpleados.SelectedIndex = -1;
        }

        //Seccion para llamar los id Empleados y mostrarlos en un ComboBox y relacionarlos con un Usuario 
        private void formulario_CrearUsuario_Load(object sender, EventArgs e)
        {
            string connectionString = "server=DESKTOP-PFTDRUB;database=bsd_SistemaOrion;integrated security=true";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT id_empleado FROM Empleados"; 
                    SqlCommand cmd = new SqlCommand(query, conexion);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox_IdEmpleados.Items.Add(reader["id_empleado"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los IDs de los empleados: " + ex.Message);
                }
            }


            CargarUsuariosEnGrid();

        }

        //Seccion para mostrar los Usuarios creados 
        private void CargarUsuariosEnGrid()
        {
            string connectionString = "server=DESKTOP-PFTDRUB;database=bsd_SistemaOrion;integrated security=true";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT id_usuario, usuario, tipo_usuario, id_empleado FROM Usuarios";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conexion);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGrid_usuarios.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
                }
            }
        }


        //button regresar

        private void button_regresar_Click(object sender, EventArgs e)
        {
            Inicio_Dashboard frmDash = new Inicio_Dashboard();

            Inicio_administracion frmAdministracion = new Inicio_administracion();

            Inicio_admin frmAdmin = new Inicio_admin();

            this.Close();

            switch (TipoUsuarioGlobal.TipoUsuario)
            {
                case "empleado":
                    frmDash.Show();
                    break;
                case "administracion":
                    frmAdministracion.Show();
                    break;
                case "admin":
                    frmAdmin.Show();
                    break;
            }
        }


        //--------------------------------------------------

        private void dataGrid_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }
    }

        


}
