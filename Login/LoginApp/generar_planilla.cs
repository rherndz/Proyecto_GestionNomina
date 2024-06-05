using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LoginApp.Login_form;

namespace LoginApp
{
    public partial class generar_planilla : Form
    {
        public generar_planilla()
        {
            InitializeComponent();
        }

        //Button Regresar
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


        //Enlace a la clase Conexion_sql
        SqlConnection conexion = new SqlConnection("server = DESKTOP-PFTDRUB; dataBase = bsd_SistemaOrion; integrated security = true");


        private void btn_Agregar_Empleado_Click(object sender, EventArgs e)
        {
            
        }



        //Metodo para cargar a los empleados

        private void generar_planilla_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_AgregarDias_Click(object sender, EventArgs e)
        {
        }


        private void btn_Limpiar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
