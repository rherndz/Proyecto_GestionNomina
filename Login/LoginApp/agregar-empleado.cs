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
using static LoginApp.Login_form;

namespace LoginApp
{
    public partial class AgregarEmpleado_Form : Form
    {
        public AgregarEmpleado_Form()
        {
            InitializeComponent();

            comboBox_dept.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox_afiliacion.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox_edad.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox_LaborEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox_CategoriaEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //Enlace a la clase Conexion_sql
        SqlConnection conexion = new SqlConnection("server = DESKTOP-PFTDRUB; dataBase = bsd_SistemaOrion; integrated security = true");


        private void button_agregar_Click(object sender, EventArgs e)
        {


            // Validar que todos los campos necesarios no estén vacíos
            if (string.IsNullOrEmpty(txtbox_empleadoID.Text) || string.IsNullOrEmpty(txtBox_primNombre.Text) ||
                string.IsNullOrEmpty(txtBox_segudNombre.Text) || string.IsNullOrEmpty(txtBox_primApell.Text) ||
                string.IsNullOrEmpty(txtBox_segudApell.Text) || comboBox_edad.SelectedItem == null ||
                string.IsNullOrEmpty(txtBox_direccion.Text) || comboBox_dept.SelectedItem == null ||
                string.IsNullOrEmpty(txtbox_municipio.Text) || string.IsNullOrEmpty(maskedText_duiEmpleado.Text) ||
                string.IsNullOrEmpty(masked_numISSS.Text) || string.IsNullOrEmpty(txtBox_CodigoSap.Text) ||
                comboBox_afiliacion.SelectedItem == null || string.IsNullOrEmpty(masked_codigoAfilicion.Text) ||
                string.IsNullOrEmpty(txtBox_tipCuenta.Text) || string.IsNullOrEmpty(masked_numCuenta.Text) ||
                string.IsNullOrEmpty(maskedText_telefonoEmpleado.Text) || comboBox_CategoriaEmpleado.SelectedItem == null ||
                string.IsNullOrEmpty(comboBox_LaborEmpleado.Text) || string.IsNullOrEmpty(txtBox_SalarioBase.Text) ||
                string.IsNullOrEmpty(maskedText_FechaIngreso.Text))
            {
                MessageBox.Show("Por favor complete todos los campos antes de enviar.");
                return;
            }

            string agregar = "INSERT INTO Empleados (id_empleado, p_nombre_empleado, s_nombre_empleado, p_apellido_empleado, s_apellido_empleado, edad_empleado, direccion_empleado, direccion_departamento, " +
                        "direccion_municipio, dui_empleado, iss_empleado, codigo_sap, afiliacion_empleado, afiliacion_code, tipo_cuenta, numero_cuenta, telefono_empleado, categoria_empleado, labor_empleado, sueldoBase_empleado, fecha_ingreso_emp) " +
                        "VALUES (@id_empleado, @p_nombre_empleado, @s_nombre_empleado, @p_apellido_empleado, @s_apellido_empleado, @edad_empleado, @direccion_empleado, @direccion_departamento, @direccion_municipio, " +
                        "@dui_empleado, @iss_empleado, @codigo_sap, @afiliacion_empleado, @afiliacion_code, @tipo_cuenta, @numero_cuenta, @telefono_empleado, @categoria_empleado, @labor_empleado, @sueldoBase_empleado, @fecha_ingreso_emp)";

            SqlCommand cmd = new SqlCommand(agregar, conexion);

            cmd.Parameters.AddWithValue("@id_empleado", txtbox_empleadoID.Text);
            cmd.Parameters.AddWithValue("@p_nombre_empleado", txtBox_primNombre.Text);
            cmd.Parameters.AddWithValue("@s_nombre_empleado", txtBox_segudNombre.Text);
            cmd.Parameters.AddWithValue("@p_apellido_empleado", txtBox_primApell.Text);
            cmd.Parameters.AddWithValue("@s_apellido_empleado", txtBox_segudApell.Text);
            cmd.Parameters.AddWithValue("@edad_empleado", comboBox_edad.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@direccion_empleado", txtBox_direccion.Text);
            cmd.Parameters.AddWithValue("@direccion_departamento", comboBox_dept.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@direccion_municipio", txtbox_municipio.Text);
            cmd.Parameters.AddWithValue("@dui_empleado", maskedText_duiEmpleado.Text);
            cmd.Parameters.AddWithValue("@iss_empleado", masked_numISSS.Text);
            cmd.Parameters.AddWithValue("@codigo_sap", txtBox_CodigoSap.Text);
            cmd.Parameters.AddWithValue("@afiliacion_empleado", comboBox_afiliacion.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@afiliacion_code", masked_codigoAfilicion.Text);
            cmd.Parameters.AddWithValue("@tipo_cuenta", txtBox_tipCuenta.Text);
            cmd.Parameters.AddWithValue("@numero_cuenta", masked_numCuenta.Text);
            cmd.Parameters.AddWithValue("@telefono_empleado", maskedText_telefonoEmpleado.Text);
            cmd.Parameters.AddWithValue("@categoria_empleado", comboBox_CategoriaEmpleado.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@labor_empleado", comboBox_LaborEmpleado.Text);
            cmd.Parameters.AddWithValue("@sueldoBase_empleado", decimal.Parse(txtBox_SalarioBase.Text));
            cmd.Parameters.AddWithValue("@fecha_ingreso_emp", DateTime.Parse(maskedText_FechaIngreso.Text));

            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("El Empleado fue agregado exitosamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el empleado: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

        }

        //Metodo para limpiar los campos 

        public void LimpiarCampos()
        {
            txtbox_empleadoID.Clear();
            txtBox_primNombre.Clear();
            txtBox_segudNombre.Clear();
            txtBox_primApell.Clear();
            txtBox_segudApell.Clear();
            comboBox_edad.SelectedIndex = -1; // Limpia la selección del ComboBox
            txtBox_direccion.Clear();
            comboBox_dept.SelectedIndex = -1; // Limpia la selección del ComboBox
            txtbox_municipio.Clear();
            maskedText_duiEmpleado.Clear();
            masked_numISSS.Clear();
            txtBox_CodigoSap.Clear();
            comboBox_afiliacion.SelectedIndex = -1; // Limpia la selección del ComboBox
            masked_codigoAfilicion.Clear();
            txtBox_tipCuenta.Clear();
            masked_numCuenta.Clear();
            maskedText_telefonoEmpleado.Clear();
            comboBox_CategoriaEmpleado.SelectedIndex = -1; // Limpia la selección del ComboBox
            comboBox_LaborEmpleado.SelectedIndex = -1; // Limpia la selección del ComboBox
            txtBox_SalarioBase.Clear();
            maskedText_FechaIngreso.Clear();

        }


        private void button_borrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


        //Button para generar un numero random para el ID Empleado

        private void button_generarID_Click(object sender, EventArgs e)
        {

            Random randomId = new Random();

            Random randomCaracter = new Random();

            int code;

            string characters = "0123456789";
            var charsarr = new char[2];
            var random = new Random();

            var resultado = new string(charsarr);

            for (int i = 0; i < 10; i++)
            {

                code = randomId.Next(10, 9000);

                for (int j = 0; j < charsarr.Length; j++)
                {

                    charsarr[j] = characters[random.Next(characters.Length)];

                    resultado = new string(charsarr);
                }


                txtbox_empleadoID.Text = code.ToString() + resultado;
            }
        }

        //Button para generar un numero random para el codigo SAP 

        private void button_generarSAP_Click(object sender, EventArgs e)
        {

            Random randomId = new Random();

            Random randomCaracter = new Random();

            int code;

            string characters = "0123456789";
            var charsarr = new char[4];
            var random = new Random();

            var resultado = new string(charsarr);

            for (int i = 0; i < 10; i++)
            {

                code = randomId.Next(10, 10000);

                for (int j = 0; j < charsarr.Length; j++)
                {

                    charsarr[j] = characters[random.Next(characters.Length)];

                    resultado = new string(charsarr);
                }


                txtBox_CodigoSap.Text = code.ToString() + "-" + resultado;
            }


        }


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

        private void comboBox_dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox_afiliacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox_CategoriaEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox_LaborEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
