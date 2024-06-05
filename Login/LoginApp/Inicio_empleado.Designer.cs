namespace LoginApp
{
    partial class Inicio_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bttn_AgregarEmpleado = new System.Windows.Forms.Button();
            this.btn_EditarEmpleado = new System.Windows.Forms.Button();
            this.btn_MostrarEmpleado = new System.Windows.Forms.Button();
            this.btn_GenerarPlanilla = new System.Windows.Forms.Button();
            this.btn_Incapacidades = new System.Windows.Forms.Button();
            this.btn_Vaciones = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.seccionpanel_home = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 82);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(208, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(895, 50);
            this.panel4.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(681, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "BIENVENIDO USUARIO EMPLEADO";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(0, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 58);
            this.panel5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Usuario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 590);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bttn_AgregarEmpleado);
            this.flowLayoutPanel1.Controls.Add(this.btn_EditarEmpleado);
            this.flowLayoutPanel1.Controls.Add(this.btn_MostrarEmpleado);
            this.flowLayoutPanel1.Controls.Add(this.btn_GenerarPlanilla);
            this.flowLayoutPanel1.Controls.Add(this.btn_Incapacidades);
            this.flowLayoutPanel1.Controls.Add(this.btn_Vaciones);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 73);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(154, 430);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // bttn_AgregarEmpleado
            // 
            this.bttn_AgregarEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttn_AgregarEmpleado.Location = new System.Drawing.Point(3, 3);
            this.bttn_AgregarEmpleado.Name = "bttn_AgregarEmpleado";
            this.bttn_AgregarEmpleado.Size = new System.Drawing.Size(154, 37);
            this.bttn_AgregarEmpleado.TabIndex = 1;
            this.bttn_AgregarEmpleado.Text = "Agregar Empleado";
            this.bttn_AgregarEmpleado.UseVisualStyleBackColor = true;
            this.bttn_AgregarEmpleado.Click += new System.EventHandler(this.bttn_AgregarEmpleado_Click);
            // 
            // btn_EditarEmpleado
            // 
            this.btn_EditarEmpleado.Location = new System.Drawing.Point(3, 46);
            this.btn_EditarEmpleado.Name = "btn_EditarEmpleado";
            this.btn_EditarEmpleado.Size = new System.Drawing.Size(154, 37);
            this.btn_EditarEmpleado.TabIndex = 2;
            this.btn_EditarEmpleado.Text = "Editar Empleado";
            this.btn_EditarEmpleado.UseVisualStyleBackColor = true;
            this.btn_EditarEmpleado.Click += new System.EventHandler(this.btn_EditarEmpleado_Click);
            // 
            // btn_MostrarEmpleado
            // 
            this.btn_MostrarEmpleado.Location = new System.Drawing.Point(3, 89);
            this.btn_MostrarEmpleado.Name = "btn_MostrarEmpleado";
            this.btn_MostrarEmpleado.Size = new System.Drawing.Size(154, 37);
            this.btn_MostrarEmpleado.TabIndex = 3;
            this.btn_MostrarEmpleado.Text = "Mostrar Empleado";
            this.btn_MostrarEmpleado.UseVisualStyleBackColor = true;
            this.btn_MostrarEmpleado.Click += new System.EventHandler(this.btn_MostrarEmpleado_Click);
            // 
            // btn_GenerarPlanilla
            // 
            this.btn_GenerarPlanilla.Location = new System.Drawing.Point(3, 132);
            this.btn_GenerarPlanilla.Name = "btn_GenerarPlanilla";
            this.btn_GenerarPlanilla.Size = new System.Drawing.Size(154, 37);
            this.btn_GenerarPlanilla.TabIndex = 4;
            this.btn_GenerarPlanilla.Text = "Generar Planilla";
            this.btn_GenerarPlanilla.UseVisualStyleBackColor = true;
            this.btn_GenerarPlanilla.Click += new System.EventHandler(this.btn_GenerarPlanilla_Click);
            // 
            // btn_Incapacidades
            // 
            this.btn_Incapacidades.Location = new System.Drawing.Point(3, 175);
            this.btn_Incapacidades.Name = "btn_Incapacidades";
            this.btn_Incapacidades.Size = new System.Drawing.Size(154, 37);
            this.btn_Incapacidades.TabIndex = 5;
            this.btn_Incapacidades.Text = "Incapacidades";
            this.btn_Incapacidades.UseVisualStyleBackColor = true;
            this.btn_Incapacidades.Click += new System.EventHandler(this.btn_Incapacidades_Click);
            // 
            // btn_Vaciones
            // 
            this.btn_Vaciones.Location = new System.Drawing.Point(3, 218);
            this.btn_Vaciones.Name = "btn_Vaciones";
            this.btn_Vaciones.Size = new System.Drawing.Size(154, 37);
            this.btn_Vaciones.TabIndex = 6;
            this.btn_Vaciones.Text = "Vaciones";
            this.btn_Vaciones.UseVisualStyleBackColor = true;
            this.btn_Vaciones.Click += new System.EventHandler(this.btn_Vaciones_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.seccionpanel_home);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(194, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(922, 590);
            this.panel3.TabIndex = 2;
            // 
            // seccionpanel_home
            // 
            this.seccionpanel_home.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seccionpanel_home.Location = new System.Drawing.Point(14, 22);
            this.seccionpanel_home.Name = "seccionpanel_home";
            this.seccionpanel_home.Size = new System.Drawing.Size(895, 555);
            this.seccionpanel_home.TabIndex = 0;
            this.seccionpanel_home.Paint += new System.Windows.Forms.PaintEventHandler(this.seccionpanel_home_Paint);
            // 
            // Inicio_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1116, 672);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Inicio_Dashboard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Empleado";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel seccionpanel_home;
        private System.Windows.Forms.Button bttn_AgregarEmpleado;
        private System.Windows.Forms.Button btn_EditarEmpleado;
        private System.Windows.Forms.Button btn_MostrarEmpleado;
        private System.Windows.Forms.Button btn_GenerarPlanilla;
        private System.Windows.Forms.Button btn_Incapacidades;
        private System.Windows.Forms.Button btn_Vaciones;
    }
}