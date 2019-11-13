namespace APPCOHISA
{
    partial class Cargar2
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
            this.tablaresult = new System.Windows.Forms.DataGridView();
            this.btncaefar = new System.Windows.Forms.Button();
            this.btncargar = new System.Windows.Forms.Button();
            this.btnver = new System.Windows.Forms.Button();
            this.lstMatrizAF = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaresult)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaresult
            // 
            this.tablaresult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaresult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.tablaresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaresult.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.tablaresult.Location = new System.Drawing.Point(12, 127);
            this.tablaresult.Name = "tablaresult";
            this.tablaresult.Size = new System.Drawing.Size(776, 311);
            this.tablaresult.TabIndex = 1;
            // 
            // btncaefar
            // 
            this.btncaefar.Location = new System.Drawing.Point(12, 98);
            this.btncaefar.Name = "btncaefar";
            this.btncaefar.Size = new System.Drawing.Size(75, 23);
            this.btncaefar.TabIndex = 2;
            this.btncaefar.Text = "carga y llena";
            this.btncaefar.UseVisualStyleBackColor = true;
            this.btncaefar.Click += new System.EventHandler(this.btncaefar_Click);
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(232, 98);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(75, 23);
            this.btncargar.TabIndex = 5;
            this.btncargar.Text = "cargar";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnver
            // 
            this.btnver.Location = new System.Drawing.Point(313, 98);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(75, 23);
            this.btnver.TabIndex = 6;
            this.btnver.Text = "Ver";
            this.btnver.UseVisualStyleBackColor = true;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // lstMatrizAF
            // 
            this.lstMatrizAF.FormattingEnabled = true;
            this.lstMatrizAF.Location = new System.Drawing.Point(72, 180);
            this.lstMatrizAF.Name = "lstMatrizAF";
            this.lstMatrizAF.Size = new System.Drawing.Size(535, 199);
            this.lstMatrizAF.TabIndex = 7;
            // 
            // Cargar2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMatrizAF);
            this.Controls.Add(this.btnver);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.btncaefar);
            this.Controls.Add(this.tablaresult);
            this.Name = "Cargar2";
            this.Text = "Cargar2";
            this.Load += new System.EventHandler(this.Cargar2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaresult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tablaresult;
        private System.Windows.Forms.Button btncaefar;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.Button btnver;
        private System.Windows.Forms.ListBox lstMatrizAF;
    }
}