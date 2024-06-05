namespace LoginApp
{
    partial class formulario_CrearUsuario
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button_regresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_idUsuario = new System.Windows.Forms.TextBox();
            this.txtbox_usuario = new System.Windows.Forms.TextBox();
            this.txtbox_contrasena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_crear = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGrid_usuarios = new System.Windows.Forms.DataGridView();
            this.comboBox_tipoUsuario = new System.Windows.Forms.ComboBox();
            this.errorProviderUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContrasena = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox_IdEmpleados = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContrasena)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button_regresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 71);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(170, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 47);
            this.panel2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(693, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(267, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Usuario";
            // 
            // button_regresar
            // 
            this.button_regresar.BackColor = System.Drawing.Color.Red;
            this.button_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_regresar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_regresar.ForeColor = System.Drawing.Color.White;
            this.button_regresar.Location = new System.Drawing.Point(17, 17);
            this.button_regresar.Name = "button_regresar";
            this.button_regresar.Size = new System.Drawing.Size(129, 35);
            this.button_regresar.TabIndex = 2;
            this.button_regresar.Text = "REGRESAR";
            this.button_regresar.UseVisualStyleBackColor = false;
            this.button_regresar.Click += new System.EventHandler(this.button_regresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Crear un Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre Usuario:";
            // 
            // txtbox_idUsuario
            // 
            this.txtbox_idUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_idUsuario.Location = new System.Drawing.Point(128, 216);
            this.txtbox_idUsuario.Name = "txtbox_idUsuario";
            this.txtbox_idUsuario.Size = new System.Drawing.Size(138, 23);
            this.txtbox_idUsuario.TabIndex = 3;
            this.txtbox_idUsuario.TextChanged += new System.EventHandler(this.txtbox_idUsuario_TextChanged);
            // 
            // txtbox_usuario
            // 
            this.txtbox_usuario.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_usuario.Location = new System.Drawing.Point(128, 99);
            this.txtbox_usuario.Name = "txtbox_usuario";
            this.txtbox_usuario.Size = new System.Drawing.Size(138, 23);
            this.txtbox_usuario.TabIndex = 4;
            this.txtbox_usuario.TextChanged += new System.EventHandler(this.txtbox_usuario_TextChanged);
            // 
            // txtbox_contrasena
            // 
            this.txtbox_contrasena.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_contrasena.Location = new System.Drawing.Point(128, 156);
            this.txtbox_contrasena.Name = "txtbox_contrasena";
            this.txtbox_contrasena.Size = new System.Drawing.Size(138, 23);
            this.txtbox_contrasena.TabIndex = 5;
            this.txtbox_contrasena.TextChanged += new System.EventHandler(this.txtbox_contrasena_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tipo Usuario:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.comboBox_IdEmpleados);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.comboBox_tipoUsuario);
            this.panel4.Controls.Add(this.btn_crear);
            this.panel4.Controls.Add(this.btn_limpiar);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtbox_contrasena);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtbox_idUsuario);
            this.panel4.Controls.Add(this.txtbox_usuario);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 511);
            this.panel4.TabIndex = 15;
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(167, 430);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(113, 30);
            this.btn_crear.TabIndex = 14;
            this.btn_crear.Text = "Crear ";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(32, 430);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(113, 30);
            this.btn_limpiar.TabIndex = 13;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dataGrid_usuarios);
            this.panel3.Location = new System.Drawing.Point(326, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 486);
            this.panel3.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "Usuarios Creados";
            // 
            // dataGrid_usuarios
            // 
            this.dataGrid_usuarios.AllowUserToAddRows = false;
            this.dataGrid_usuarios.AllowUserToDeleteRows = false;
            this.dataGrid_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_usuarios.Location = new System.Drawing.Point(30, 93);
            this.dataGrid_usuarios.Name = "dataGrid_usuarios";
            this.dataGrid_usuarios.ReadOnly = true;
            this.dataGrid_usuarios.Size = new System.Drawing.Size(692, 354);
            this.dataGrid_usuarios.TabIndex = 0;
            this.dataGrid_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_usuarios_CellContentClick);
            // 
            // comboBox_tipoUsuario
            // 
            this.comboBox_tipoUsuario.FormattingEnabled = true;
            this.comboBox_tipoUsuario.Items.AddRange(new object[] {
            "",
            "empleado",
            "administracion",
            "admin"});
            this.comboBox_tipoUsuario.Location = new System.Drawing.Point(128, 331);
            this.comboBox_tipoUsuario.Name = "comboBox_tipoUsuario";
            this.comboBox_tipoUsuario.Size = new System.Drawing.Size(138, 21);
            this.comboBox_tipoUsuario.TabIndex = 15;
            // 
            // errorProviderUsuario
            // 
            this.errorProviderUsuario.ContainerControl = this;
            // 
            // errorProviderContrasena
            // 
            this.errorProviderContrasena.ContainerControl = this;
            // 
            // comboBox_IdEmpleados
            // 
            this.comboBox_IdEmpleados.FormattingEnabled = true;
            this.comboBox_IdEmpleados.Items.AddRange(new object[] {
            ""});
            this.comboBox_IdEmpleados.Location = new System.Drawing.Point(128, 276);
            this.comboBox_IdEmpleados.Name = "comboBox_IdEmpleados";
            this.comboBox_IdEmpleados.Size = new System.Drawing.Size(138, 21);
            this.comboBox_IdEmpleados.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Id Empleado:";
            // 
            // formulario_CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1089, 582);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "formulario_CrearUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "crear_usuario";
            this.Load += new System.EventHandler(this.formulario_CrearUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContrasena)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_regresar;
        private System.Windows.Forms.TextBox txtbox_idUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_contrasena;
        private System.Windows.Forms.TextBox txtbox_usuario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGrid_usuarios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_tipoUsuario;
        private System.Windows.Forms.ErrorProvider errorProviderUsuario;
        private System.Windows.Forms.ErrorProvider errorProviderContrasena;
        private System.Windows.Forms.ComboBox comboBox_IdEmpleados;
        private System.Windows.Forms.Label label8;
    }
}