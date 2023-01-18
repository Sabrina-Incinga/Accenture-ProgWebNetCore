namespace PresentaciónVehiculos
{
    partial class Form1
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
            this.btnAcelerar = new System.Windows.Forms.Button();
            this.btnRemolque = new System.Windows.Forms.Button();
            this.btnFrenar = new System.Windows.Forms.Button();
            this.txtCamion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAcelerar
            // 
            this.btnAcelerar.Location = new System.Drawing.Point(474, 66);
            this.btnAcelerar.Name = "btnAcelerar";
            this.btnAcelerar.Size = new System.Drawing.Size(75, 23);
            this.btnAcelerar.TabIndex = 1;
            this.btnAcelerar.Text = "Acelerar";
            this.btnAcelerar.UseVisualStyleBackColor = true;
            this.btnAcelerar.Click += new System.EventHandler(this.btnAcelerar_Click);
            // 
            // btnRemolque
            // 
            this.btnRemolque.Location = new System.Drawing.Point(474, 152);
            this.btnRemolque.Name = "btnRemolque";
            this.btnRemolque.Size = new System.Drawing.Size(139, 23);
            this.btnRemolque.TabIndex = 3;
            this.btnRemolque.Text = "Quitar Remolque";
            this.btnRemolque.UseVisualStyleBackColor = true;
            this.btnRemolque.Click += new System.EventHandler(this.btnRemolque_Click);
            // 
            // btnFrenar
            // 
            this.btnFrenar.Location = new System.Drawing.Point(474, 109);
            this.btnFrenar.Name = "btnFrenar";
            this.btnFrenar.Size = new System.Drawing.Size(75, 23);
            this.btnFrenar.TabIndex = 4;
            this.btnFrenar.Text = "Frenar";
            this.btnFrenar.UseVisualStyleBackColor = true;
            this.btnFrenar.Click += new System.EventHandler(this.btnFrenar_Click);
            // 
            // txtCamion
            // 
            this.txtCamion.Location = new System.Drawing.Point(59, 66);
            this.txtCamion.Multiline = true;
            this.txtCamion.Name = "txtCamion";
            this.txtCamion.Size = new System.Drawing.Size(392, 200);
            this.txtCamion.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCamion);
            this.Controls.Add(this.btnFrenar);
            this.Controls.Add(this.btnRemolque);
            this.Controls.Add(this.btnAcelerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAcelerar;
        private System.Windows.Forms.Button btnRemolque;
        private System.Windows.Forms.Button btnFrenar;
        private System.Windows.Forms.TextBox txtCamion;
    }
}

