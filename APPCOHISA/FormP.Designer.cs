namespace APPCOHISA
{
    partial class FormP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormP));
            this.btnInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(316, 243);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(269, 44);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "button1";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // FormP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInicio);
            this.Name = "FormP";
            this.Text = "Portada";
            this.Load += new System.EventHandler(this.FormP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
    }
}

