namespace WindowsApp
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
            this.btn_showProduct = new System.Windows.Forms.Button();
            this.btn_showCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_showProduct
            // 
            this.btn_showProduct.BackColor = System.Drawing.Color.Peru;
            this.btn_showProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_showProduct.Location = new System.Drawing.Point(163, 180);
            this.btn_showProduct.Name = "btn_showProduct";
            this.btn_showProduct.Size = new System.Drawing.Size(208, 45);
            this.btn_showProduct.TabIndex = 0;
            this.btn_showProduct.Text = "Mostrar Producto";
            this.btn_showProduct.UseVisualStyleBackColor = false;
            this.btn_showProduct.Click += new System.EventHandler(this.btn_showProduct_Click);
            // 
            // btn_showCustomer
            // 
            this.btn_showCustomer.BackColor = System.Drawing.Color.IndianRed;
            this.btn_showCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_showCustomer.Location = new System.Drawing.Point(428, 180);
            this.btn_showCustomer.Name = "btn_showCustomer";
            this.btn_showCustomer.Size = new System.Drawing.Size(208, 45);
            this.btn_showCustomer.TabIndex = 1;
            this.btn_showCustomer.Text = "Mostrar cliente";
            this.btn_showCustomer.UseVisualStyleBackColor = false;
            this.btn_showCustomer.Click += new System.EventHandler(this.btn_showCustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_showCustomer);
            this.Controls.Add(this.btn_showProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_showProduct;
        private System.Windows.Forms.Button btn_showCustomer;
    }
}

