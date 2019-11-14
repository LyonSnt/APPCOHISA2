namespace APPCOHISA
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AFD = new System.Windows.Forms.TabPage();
            this.Alfabeto = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AFD);
            this.tabControl1.Controls.Add(this.Alfabeto);
            this.tabControl1.Location = new System.Drawing.Point(65, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 397);
            this.tabControl1.TabIndex = 0;
            // 
            // AFD
            // 
            this.AFD.Location = new System.Drawing.Point(4, 22);
            this.AFD.Name = "AFD";
            this.AFD.Padding = new System.Windows.Forms.Padding(3);
            this.AFD.Size = new System.Drawing.Size(727, 371);
            this.AFD.TabIndex = 0;
            this.AFD.Text = "Tab_AFD";
            this.AFD.UseVisualStyleBackColor = true;
            // 
            // Alfabeto
            // 
            this.Alfabeto.Location = new System.Drawing.Point(4, 22);
            this.Alfabeto.Name = "Alfabeto";
            this.Alfabeto.Padding = new System.Windows.Forms.Padding(3);
            this.Alfabeto.Size = new System.Drawing.Size(792, 424);
            this.Alfabeto.TabIndex = 1;
            this.Alfabeto.Text = "Tab_Alfabeto";
            this.Alfabeto.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkRed;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 25);
            this.button5.TabIndex = 16;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Frm_Load_AFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Load_AFD";
            this.Text = "AFD";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AFD;
        private System.Windows.Forms.TabPage Alfabeto;
        private System.Windows.Forms.Button button5;
    }
}