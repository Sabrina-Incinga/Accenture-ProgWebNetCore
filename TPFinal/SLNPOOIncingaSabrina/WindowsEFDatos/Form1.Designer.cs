namespace WindowsEFDatos
{
    partial class frmAvion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridAviones = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.txtIdLinea = new System.Windows.Forms.TextBox();
            this.btnCrearAvion = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAviones)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAviones
            // 
            this.gridAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAviones.Location = new System.Drawing.Point(82, 79);
            this.gridAviones.Name = "gridAviones";
            this.gridAviones.Size = new System.Drawing.Size(240, 150);
            this.gridAviones.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(558, 80);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(558, 116);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidad.TabIndex = 2;
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Location = new System.Drawing.Point(558, 156);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(100, 20);
            this.txtDenominacion.TabIndex = 3;
            // 
            // txtIdLinea
            // 
            this.txtIdLinea.Location = new System.Drawing.Point(558, 196);
            this.txtIdLinea.Name = "txtIdLinea";
            this.txtIdLinea.Size = new System.Drawing.Size(100, 20);
            this.txtIdLinea.TabIndex = 4;
            // 
            // btnCrearAvion
            // 
            this.btnCrearAvion.Location = new System.Drawing.Point(558, 249);
            this.btnCrearAvion.Name = "btnCrearAvion";
            this.btnCrearAvion.Size = new System.Drawing.Size(100, 23);
            this.btnCrearAvion.TabIndex = 5;
            this.btnCrearAvion.Text = "Crear Avion";
            this.btnCrearAvion.UseVisualStyleBackColor = true;
            this.btnCrearAvion.Click += new System.EventHandler(this.btnCrearAvion_Click);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(493, 87);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 6;
            this.Id.Text = "Id";
            this.Id.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(467, 123);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 7;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Id Línea Aérea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Denominacion";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(558, 336);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar Avion";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(558, 292);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 23);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Editar Avion";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(688, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar Avion";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.btnCrearAvion);
            this.Controls.Add(this.txtIdLinea);
            this.Controls.Add(this.txtDenominacion);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.gridAviones);
            this.Name = "frmAvion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAvion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAviones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAviones;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtDenominacion;
        private System.Windows.Forms.TextBox txtIdLinea;
        private System.Windows.Forms.Button btnCrearAvion;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
    }
}

