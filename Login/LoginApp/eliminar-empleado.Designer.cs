namespace LoginApp
{
    partial class eliminar_empleado
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_regresar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtbox_papellido = new System.Windows.Forms.TextBox();
            this.txtbox_pNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_buscarEmpleados = new System.Windows.Forms.Button();
            this.comboBox_tipoEmpleado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_IdEmpleado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1113, 76);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(178, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 43);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(301, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar Empleados";
            // 
            // button_regresar
            // 
            this.button_regresar.BackColor = System.Drawing.Color.Red;
            this.button_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_regresar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_regresar.ForeColor = System.Drawing.Color.White;
            this.button_regresar.Location = new System.Drawing.Point(23, 21);
            this.button_regresar.Name = "button_regresar";
            this.button_regresar.Size = new System.Drawing.Size(129, 35);
            this.button_regresar.TabIndex = 4;
            this.button_regresar.Text = "REGRESAR";
            this.button_regresar.UseVisualStyleBackColor = false;
            this.button_regresar.Click += new System.EventHandler(this.button_regresar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(977, 660);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Eliminar Empleado";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtbox_papellido
            // 
            this.txtbox_papellido.Location = new System.Drawing.Point(914, 24);
            this.txtbox_papellido.Name = "txtbox_papellido";
            this.txtbox_papellido.Size = new System.Drawing.Size(179, 20);
            this.txtbox_papellido.TabIndex = 4;
            this.txtbox_papellido.TextChanged += new System.EventHandler(this.txtbox_papellido_TextChanged);
            // 
            // txtbox_pNombre
            // 
            this.txtbox_pNombre.Location = new System.Drawing.Point(663, 24);
            this.txtbox_pNombre.Name = "txtbox_pNombre";
            this.txtbox_pNombre.Size = new System.Drawing.Size(157, 20);
            this.txtbox_pNombre.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(845, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Apellido:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(596, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btn_buscarEmpleados);
            this.panel4.Controls.Add(this.comboBox_tipoEmpleado);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtbox_IdEmpleado);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtbox_pNombre);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtbox_papellido);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1113, 108);
            this.panel4.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecciona un Empleados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(989, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_buscarEmpleados
            // 
            this.btn_buscarEmpleados.Location = new System.Drawing.Point(867, 67);
            this.btn_buscarEmpleados.Name = "btn_buscarEmpleados";
            this.btn_buscarEmpleados.Size = new System.Drawing.Size(104, 23);
            this.btn_buscarEmpleados.TabIndex = 12;
            this.btn_buscarEmpleados.Text = "Buscar";
            this.btn_buscarEmpleados.UseVisualStyleBackColor = true;
            // 
            // comboBox_tipoEmpleado
            // 
            this.comboBox_tipoEmpleado.FormattingEnabled = true;
            this.comboBox_tipoEmpleado.Items.AddRange(new object[] {
            "",
            "Albañil",
            "Col. Solera",
            "Pintor",
            "Moldero",
            "Armador",
            "Carpintero",
            "Cordonero",
            "Pilero"});
            this.comboBox_tipoEmpleado.Location = new System.Drawing.Point(675, 69);
            this.comboBox_tipoEmpleado.Name = "comboBox_tipoEmpleado";
            this.comboBox_tipoEmpleado.Size = new System.Drawing.Size(145, 21);
            this.comboBox_tipoEmpleado.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(623, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Labor:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "",
            "Administracion 1",
            "Administracion 2",
            "Auxiliar",
            "Obrero"});
            this.comboBox2.Location = new System.Drawing.Point(439, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(149, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(326, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tipo - Categoria:";
            // 
            // txtbox_IdEmpleado
            // 
            this.txtbox_IdEmpleado.Location = new System.Drawing.Point(447, 24);
            this.txtbox_IdEmpleado.Name = "txtbox_IdEmpleado";
            this.txtbox_IdEmpleado.Size = new System.Drawing.Size(118, 20);
            this.txtbox_IdEmpleado.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(352, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "ID Empleado:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(23, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1071, 447);
            this.panel3.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1036, 413);
            this.dataGridView1.TabIndex = 11;
            // 
            // eliminar_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1113, 702);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "eliminar_empleado";
            this.Text = "eliminar_empleado";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_regresar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtbox_papellido;
        private System.Windows.Forms.TextBox txtbox_pNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_tipoEmpleado;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbox_IdEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_buscarEmpleados;
        private System.Windows.Forms.Label label3;
    }
}