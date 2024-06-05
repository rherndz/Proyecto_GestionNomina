﻿using System;
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
    public partial class Inicio_administracion : Form
    {
        public Inicio_administracion()
        {
            InitializeComponent();
        }

        //Button - Menu principal

        private void bttn_AgregarEmpleado_Click(object sender, EventArgs e)
        {
            AgregarEmpleado_Form frmAgregarEmpleado = new AgregarEmpleado_Form();

            this.Hide();

            frmAgregarEmpleado.Show();

        }

        private void bttn_EditarEmpleado_Click(object sender, EventArgs e)
        {
            Editar_Empleados frmEditarEmpleado = new Editar_Empleados();

            this.Hide();

            frmEditarEmpleado.Show();
        }

        private void bttn_EliminarEmpleado_Click(object sender, EventArgs e)
        {
           eliminar_empleado frmEliminarEmpleado = new eliminar_empleado();

            this.Hide();

            frmEliminarEmpleado.Show();
        }

        private void btton_EmpleadosEliminados_Click(object sender, EventArgs e)
        {

        }

        private void bttn_MostrarEmpleados_Click(object sender, EventArgs e)
        {
            Mostrar_Empleados frmMostrarEmpleado = new Mostrar_Empleados();

            this.Hide();

            frmMostrarEmpleado.Show();
        }

        private void bttn_GenerarPlanilla_Click(object sender, EventArgs e)
        {
            generar_planilla frnGenerarPlanilla = new generar_planilla();

            this.Hide();

            frnGenerarPlanilla.Show();
        }

        private void btn_Incapacidades_Click(object sender, EventArgs e)
        {

        }

        private void btn_Vaciones_Click(object sender, EventArgs e)
        {
            vacacion_empleado frmVacionesEmpleado = new vacacion_empleado();

            this.Hide();

            frmVacionesEmpleado.Show();
        }

        private void btn_PagosRealizados_Click(object sender, EventArgs e)
        {

        }

        private void bttn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
