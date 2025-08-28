namespace Crud
{
    partial class frmPrincipalRegistro
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnCrearCuentaPrincipal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlPrincipa = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIniciar);
            this.panel1.Controls.Add(this.btnCrearCuentaPrincipal);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 553);
            this.panel1.TabIndex = 0;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(108, 360);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(86, 45);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar Sesion";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCrearCuentaPrincipal
            // 
            this.btnCrearCuentaPrincipal.Location = new System.Drawing.Point(13, 360);
            this.btnCrearCuentaPrincipal.Name = "btnCrearCuentaPrincipal";
            this.btnCrearCuentaPrincipal.Size = new System.Drawing.Size(75, 45);
            this.btnCrearCuentaPrincipal.TabIndex = 1;
            this.btnCrearCuentaPrincipal.Text = "Crear Cuenta";
            this.btnCrearCuentaPrincipal.UseVisualStyleBackColor = true;
            this.btnCrearCuentaPrincipal.Click += new System.EventHandler(this.btnCrearCuentaPrincipal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Crud.Properties.Resources.computadora;
            this.pictureBox1.Location = new System.Drawing.Point(27, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlPrincipa
            // 
            this.pnlPrincipa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipa.Location = new System.Drawing.Point(200, 0);
            this.pnlPrincipa.Name = "pnlPrincipa";
            this.pnlPrincipa.Size = new System.Drawing.Size(642, 553);
            this.pnlPrincipa.TabIndex = 1;
            // 
            // frmPrincipalRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 553);
            this.Controls.Add(this.pnlPrincipa);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipalRegistro";
            this.Text = "frmPrincipalRegistro";
            this.Load += new System.EventHandler(this.frmPrincipalRegistro_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCrearCuentaPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlPrincipa;
        private System.Windows.Forms.Button btnIniciar;
    }
}