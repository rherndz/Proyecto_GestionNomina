using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LoginApp.Login_form;

namespace LoginApp
{
    public partial class eliminar_empleado : Form
    {
        public eliminar_empleado()
        {
            InitializeComponent();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_papellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
