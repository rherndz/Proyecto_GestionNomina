namespace LoginApp
{
    partial class Editar_Empleados
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button_ventEditar = new System.Windows.Forms.Button();
            this.dataGrid_MostrarEmpleados = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_MostrarEmpleados)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1119, 76);
            this.panel1.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar Empleado";
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button_ventEditar);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(23, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1071, 52);
            this.panel4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecciona un Empleados";
            // 
            // button_ventEditar
            // 
            this.button_ventEditar.Location = new System.Drawing.Point(937, 11);
            this.button_ventEditar.Name = "button_ventEditar";
            this.button_ventEditar.Size = new System.Drawing.Size(117, 29);
            this.button_ventEditar.TabIndex = 8;
            this.button_ventEditar.Text = "Editar";
            this.button_ventEditar.UseVisualStyleBackColor = true;
            this.button_ventEditar.Click += new System.EventHandler(this.button_ventEditar_Click);
            // 
            // dataGrid_MostrarEmpleados
            // 
            this.dataGrid_MostrarEmpleados.AllowUserToAddRows = false;
            this.dataGrid_MostrarEmpleados.AllowUserToDeleteRows = false;
            this.dataGrid_MostrarEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_MostrarEmpleados.Location = new System.Drawing.Point(23, 171);
            this.dataGrid_MostrarEmpleados.Name = "dataGrid_MostrarEmpleados";
            this.dataGrid_MostrarEmpleados.ReadOnly = true;
            this.dataGrid_MostrarEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_MostrarEmpleados.Size = new System.Drawing.Size(1071, 495);
            this.dataGrid_MostrarEmpleados.TabIndex = 8;
            // 
            // Editar_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1119, 695);
            this.Controls.Add(this.dataGrid_MostrarEmpleados);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Editar_Empleados";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar_Empleados";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_MostrarEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_regresar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_ventEditar;
        private System.Windows.Forms.DataGridView dataGrid_MostrarEmpleados;
    }
}