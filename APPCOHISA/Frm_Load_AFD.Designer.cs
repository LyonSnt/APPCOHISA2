﻿namespace APPCOHISA
{
    partial class Frm_Load_AFD
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.PanelAFD = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.DarkRed;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnCerrar.Location = new System.Drawing.Point(0, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 16;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.button5_Click);
            // 
            // PanelAFD
            // 
            this.PanelAFD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAFD.Location = new System.Drawing.Point(0, 0);
            this.PanelAFD.Name = "PanelAFD";
            this.PanelAFD.Size = new System.Drawing.Size(800, 450);
            this.PanelAFD.TabIndex = 0;
            // 
            // Frm_Load_AFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.PanelAFD);
            this.Name = "Frm_Load_AFD";
            this.Text = "AFD";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel PanelAFD;
    }
}