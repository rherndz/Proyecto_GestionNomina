using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Inicio_admin : Form
    {
        public Inicio_admin()
        {
            InitializeComponent();
        }

        private void bttn_CrearUsuario_Click(object sender, EventArgs e)
        {
            formulario_CrearUsuario frmCrearUsuario = new formulario_CrearUsuario();

            this.Hide();

            frmCrearUsuario.Show();
        }

        private void bttn_MostrarEmpleados_Click(object sender, EventArgs e)
        {
            Mostrar_Empleados frmEmpleados = new Mostrar_Empleados();

            this.Hide();
            frmEmpleados.Show();
        }
    }
}
