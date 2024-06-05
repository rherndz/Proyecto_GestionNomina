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
    public partial class Mostrar_Empleados : Form
    {
        public Mostrar_Empleados()
        {
            InitializeComponent();

            MostrarEmpleados();
        }

        SqlConnection conexion = new SqlConnection("server = DESKTOP-PFTDRUB; dataBase = bsd_SistemaOrion; integrated security = true");

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


        private void MostrarEmpleados()
        {
            // Consulta SQL para obtener todos los registros de la tabla Empleados
            string consulta = "SELECT * FROM Empleados";

            SqlDataAdapter cmdAdapter = new SqlDataAdapter(consulta, conexion);

            DataTable dataTable = new DataTable();

            try
            {
                conexion.Open();

                cmdAdapter.Fill(dataTable);

                dataGrid_MostrarEmpleados.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los registros: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
