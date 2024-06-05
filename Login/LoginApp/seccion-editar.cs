using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class seccion_editar : Form
    {

        public seccion_editar()
        {
            InitializeComponent();

            comboBox_dept.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox_afiliacion.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox_edad.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox_LaborEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox_CategoriaEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        SqlConnection conexion = new SqlConnection("server = DESKTOP-PFTDRUB; dataBase = bsd_SistemaOrion; integrated security = true");

        private void btn_guardarCambios_Click(object sender, EventArgs e)
        {

            // Verificar si los campos obligatorios estan llenos
            if (string.IsNullOrEmpty(txtBox_primNombre.Text) ||
                string.IsNullOrEmpty(txtBox_primApell.Text) ||
                comboBox_edad.SelectedItem == null ||
                string.IsNullOrEmpty(txtBox_direccion.Text) ||
                comboBox_dept.SelectedItem == null ||
                string.IsNullOrEmpty(txtbox_municipio.Text) ||
                string.IsNullOrEmpty(maskedText_duiEmpleado.Text) ||
                string.IsNullOrEmpty(masked_numISSS.Text) ||
                comboBox_afiliacion.SelectedItem == null ||
                string.IsNullOrEmpty(masked_codigoAfilicion.Text) ||
                string.IsNullOrEmpty(txtBox_tipCuenta.Text) ||
                string.IsNullOrEmpty(masked_numCuenta.Text) ||
                string.IsNullOrEmpty(maskedText_telefonoEmpleado.Text) ||
                comboBox_CategoriaEmpleado.SelectedItem == null ||
                comboBox_LaborEmpleado.SelectedItem == null ||
                string.IsNullOrEmpty(txtBox_SalarioBase.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos obligatorios.");
                return;
            }

            // Actualizar los datos en la base de datos
            string actualizar = "UPDATE Empleados SET p_nombre_empleado = @p_nombre_empleado, s_nombre_empleado = @s_nombre_empleado, p_apellido_empleado = @p_apellido_empleado, s_apellido_empleado = @s_apellido_empleado, edad_empleado = @edad_empleado, direccion_empleado = @direccion_empleado, direccion_departamento = @direccion_departamento, direccion_municipio = @direccion_municipio, dui_empleado = @dui_empleado, iss_empleado = @iss_empleado, afiliacion_empleado = @afiliacion_empleado, afiliacion_code = @afiliacion_code, tipo_cuenta = @tipo_cuenta, numero_cuenta = @numero_cuenta, telefono_empleado = @telefono_empleado, categoria_empleado = @categoria_empleado, labor_empleado = @labor_empleado, sueldoBase_empleado = @sueldoBase_empleado, fecha_ingreso_emp = @fecha_ingreso_emp WHERE id_empleado = @id_empleado AND codigo_sap = @codigo_sap";

            using (SqlCommand cmd = new SqlCommand(actualizar, conexion))
            {   

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
                cmd.Parameters.AddWithValue("@afiliacion_empleado", comboBox_afiliacion.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@afiliacion_code", masked_codigoAfilicion.Text);
                cmd.Parameters.AddWithValue("@tipo_cuenta", txtBox_tipCuenta.Text);
                cmd.Parameters.AddWithValue("@numero_cuenta", masked_numCuenta.Text);
                cmd.Parameters.AddWithValue("@telefono_empleado", maskedText_telefonoEmpleado.Text);
                cmd.Parameters.AddWithValue("@categoria_empleado", comboBox_CategoriaEmpleado.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@labor_empleado", comboBox_LaborEmpleado.Text);
                cmd.Parameters.AddWithValue("@sueldoBase_empleado", decimal.Parse(txtBox_SalarioBase.Text));

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos actualizados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }

            this.Close();
        }


        public void CargarDatosEmpleado(string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string edad, string direccion, string departamento, string municipio, string dui, string isss, string afiliacion, string afiliacionCode, string tipoCuenta, string numeroCuenta, string telefono, string categoria, string labor, string sueldoBase, string fechaIngreso)
        {
            txtBox_primNombre.Text = primerNombre;
            txtBox_segudNombre.Text = segundoNombre;
            txtBox_primApell.Text = primerApellido;
            txtBox_segudApell.Text = segundoApellido;
            comboBox_edad.Text = edad;
            txtBox_direccion.Text = direccion;
            comboBox_dept.Text = departamento;
            txtbox_municipio.Text = municipio;
            maskedText_duiEmpleado.Text = dui;
            masked_numISSS.Text = isss;
            comboBox_afiliacion.Text = afiliacion;
            masked_codigoAfilicion.Text = afiliacionCode;
            txtBox_tipCuenta.Text = tipoCuenta;
            masked_numCuenta.Text = numeroCuenta;
            maskedText_telefonoEmpleado.Text = telefono;
            comboBox_CategoriaEmpleado.Text = categoria;
            comboBox_LaborEmpleado.Text = labor;
            txtBox_SalarioBase.Text = sueldoBase;

            // Configurar la fecha de ingreso y deshabilitar la edición
            maskedText_FechaIngreso.Text = fechaIngreso;
            maskedText_FechaIngreso.ReadOnly = true;
        }

        private void button_regresar_Click(object sender, EventArgs e)
        {
            Editar_Empleados frmEditarEmpleados = new Editar_Empleados();   

            this.Hide();

            frmEditarEmpleados.Show();
        }

    }

       
   

}
