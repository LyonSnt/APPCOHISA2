namespace PlayerUI
{
    partial class Listad
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
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtListar = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.btnbuscarr = new System.Windows.Forms.Button();
            this.btnBuscarbase = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(148, 12);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 0;
            this.btnbuscar.Text = "button1";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtListar
            // 
            this.txtListar.Location = new System.Drawing.Point(12, 12);
            this.txtListar.Name = "txtListar";
            this.txtListar.Size = new System.Drawing.Size(100, 20);
            this.txtListar.TabIndex = 1;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(12, 53);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 2;
            // 
            // tabla
            // 
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(12, 107);
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(501, 229);
            this.tabla.TabIndex = 3;
            // 
            // btnbuscarr
            // 
            this.btnbuscarr.Location = new System.Drawing.Point(148, 53);
            this.btnbuscarr.Name = "btnbuscarr";
            this.btnbuscarr.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarr.TabIndex = 4;
            this.btnbuscarr.Text = "buscar";
            this.btnbuscarr.UseVisualStyleBackColor = true;
            this.btnbuscarr.Click += new System.EventHandler(this.btnbuscarr_Click);
            // 
            // btnBuscarbase
            // 
            this.btnBuscarbase.Location = new System.Drawing.Point(289, 50);
            this.btnBuscarbase.Name = "btnBuscarbase";
            this.btnBuscarbase.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarbase.TabIndex = 5;
            this.btnBuscarbase.Text = "buscarbase";
            this.btnBuscarbase.UseVisualStyleBackColor = true;
            this.btnBuscarbase.Click += new System.EventHandler(this.btnBuscarbase_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 364);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscarbase);
            this.Controls.Add(this.btnbuscarr);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtListar);
            this.Controls.Add(this.btnbuscar);
            this.Name = "Lista";
            this.Text = "Lista";
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtListar;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Button btnbuscarr;
        private System.Windows.Forms.Button btnBuscarbase;
        private System.Windows.Forms.Button button1;
    }
}