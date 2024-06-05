using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LoginApp.Login_form;

namespace LoginApp
{
    public partial class Editar_Empleados : Form
    {
        public Editar_Empleados()
        {
            InitializeComponent();

            MostrarEmpleados(); // Metodo Mostrar Empleados
        }

        //Seccion Mostrar Empleados para Editar

        SqlConnection conexion = new SqlConnection("server = DESKTOP-PFTDRUB; dataBase = bsd_SistemaOrion; integrated security = true");

        public void MostrarEmpleados()
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

        private void button_ventEditar_Click(object sender, EventArgs e)
        {
            if (dataGrid_MostrarEmpleados.SelectedRows != null && dataGrid_MostrarEmpleados.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGrid_MostrarEmpleados.SelectedRows[0];

                // Obtener los valores de las celdas de la fila seleccionada
                string primerNombre = filaSeleccionada.Cells["p_nombre_empleado"].Value.ToString();
                string segundoNombre = filaSeleccionada.Cells["s_nombre_empleado"].Value.ToString();
                string primerApellido = filaSeleccionada.Cells["p_apellido_empleado"].Value.ToString();
                string segundoApellido = filaSeleccionada.Cells["s_apellido_empleado"].Value.ToString();
                string edad = filaSeleccionada.Cells["edad_empleado"].Value.ToString();
                string direccion = filaSeleccionada.Cells["direccion_empleado"].Value.ToString();
                string departamento = filaSeleccionada.Cells["direccion_departamento"].Value.ToString();
                string municipio = filaSeleccionada.Cells["direccion_municipio"].Value.ToString();
                string dui = filaSeleccionada.Cells["dui_empleado"].Value.ToString();
                string isss = filaSeleccionada.Cells["iss_empleado"].Value.ToString();
                string afiliacion = filaSeleccionada.Cells["afiliacion_empleado"].Value.ToString();
                string afiliacionCode = filaSeleccionada.Cells["afiliacion_code"].Value.ToString();
                string tipoCuenta = filaSeleccionada.Cells["tipo_cuenta"].Value.ToString();
                string numeroCuenta = filaSeleccionada.Cells["numero_cuenta"].Value.ToString();
                string telefono = filaSeleccionada.Cells["telefono_empleado"].Value.ToString();
                string categoria = filaSeleccionada.Cells["categoria_empleado"].Value.ToString();
                string labor = filaSeleccionada.Cells["labor_empleado"].Value.ToString();
                string sueldoBase = filaSeleccionada.Cells["sueldoBase_empleado"].Value.ToString();
                string fechaIngreso = filaSeleccionada.Cells["fecha_ingreso_emp"].Value.ToString();

                // Crear un nuevo formulario para editar y pasar los valores obtenidos
                seccion_editar frmEditarEmpleado = new seccion_editar();
                frmEditarEmpleado.CargarDatosEmpleado(primerNombre, segundoNombre, primerApellido, segundoApellido, edad, direccion, departamento, municipio, dui, isss, afiliacion, afiliacionCode, tipoCuenta, numeroCuenta, telefono, categoria, labor, sueldoBase, fechaIngreso);

                frmEditarEmpleado.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona un empleado para editar.");
            }
        }



        //Seccion de button 

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


    }
}
