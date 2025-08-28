namespace Crud
{
    partial class frmRegistrarUsuario
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombreRegistrar = new System.Windows.Forms.Label();
            this.lblCorreoRegistrar = new System.Windows.Forms.Label();
            this.lblContraseñaRegistrar = new System.Windows.Forms.Label();
            this.lblRolRegistrar = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.cmAsignarRoles = new System.Windows.Forms.ComboBox();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 80);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 434);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(542, 87);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Crud.Properties.Resources.Multimedia1;
            this.pictureBox1.Location = new System.Drawing.Point(233, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblNombreRegistrar
            // 
            this.lblNombreRegistrar.AutoSize = true;
            this.lblNombreRegistrar.Location = new System.Drawing.Point(155, 85);
            this.lblNombreRegistrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreRegistrar.Name = "lblNombreRegistrar";
            this.lblNombreRegistrar.Size = new System.Drawing.Size(58, 16);
            this.lblNombreRegistrar.TabIndex = 2;
            this.lblNombreRegistrar.Text = "Nombre:";
            // 
            // lblCorreoRegistrar
            // 
            this.lblCorreoRegistrar.AutoSize = true;
            this.lblCorreoRegistrar.Location = new System.Drawing.Point(154, 162);
            this.lblCorreoRegistrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreoRegistrar.Name = "lblCorreoRegistrar";
            this.lblCorreoRegistrar.Size = new System.Drawing.Size(52, 16);
            this.lblCorreoRegistrar.TabIndex = 3;
            this.lblCorreoRegistrar.Text = "Correo:";
            // 
            // lblContraseñaRegistrar
            // 
            this.lblContraseñaRegistrar.AutoSize = true;
            this.lblContraseñaRegistrar.Location = new System.Drawing.Point(159, 235);
            this.lblContraseñaRegistrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseñaRegistrar.Name = "lblContraseñaRegistrar";
            this.lblContraseñaRegistrar.Size = new System.Drawing.Size(78, 16);
            this.lblContraseñaRegistrar.TabIndex = 4;
            this.lblContraseñaRegistrar.Text = "Contraseña:";
            // 
            // lblRolRegistrar
            // 
            this.lblRolRegistrar.AutoSize = true;
            this.lblRolRegistrar.Location = new System.Drawing.Point(159, 312);
            this.lblRolRegistrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRolRegistrar.Name = "lblRolRegistrar";
            this.lblRolRegistrar.Size = new System.Drawing.Size(77, 16);
            this.lblRolRegistrar.TabIndex = 5;
            this.lblRolRegistrar.Text = "Asignar Rol";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(158, 114);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 25);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(158, 187);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(183, 25);
            this.txtCorreo.TabIndex = 7;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(158, 267);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(183, 25);
            this.txtContra.TabIndex = 8;
            // 
            // cmAsignarRoles
            // 
            this.cmAsignarRoles.FormattingEnabled = true;
            this.cmAsignarRoles.Location = new System.Drawing.Point(158, 338);
            this.cmAsignarRoles.Margin = new System.Windows.Forms.Padding(4);
            this.cmAsignarRoles.Name = "cmAsignarRoles";
            this.cmAsignarRoles.Size = new System.Drawing.Size(160, 24);
            this.cmAsignarRoles.TabIndex = 9;
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Location = new System.Drawing.Point(255, 387);
            this.btnCrearCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(115, 39);
            this.btnCrearCuenta.TabIndex = 10;
            this.btnCrearCuenta.Text = "Crear Cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCrearCuenta);
            this.panel2.Controls.Add(this.cmAsignarRoles);
            this.panel2.Controls.Add(this.txtContra);
            this.panel2.Controls.Add(this.txtCorreo);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.lblRolRegistrar);
            this.panel2.Controls.Add(this.lblContraseñaRegistrar);
            this.panel2.Controls.Add(this.lblCorreoRegistrar);
            this.panel2.Controls.Add(this.lblNombreRegistrar);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 521);
            this.panel2.TabIndex = 1;
            // 
            // frmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegistrarUsuario";
            this.Size = new System.Drawing.Size(542, 601);
            this.Load += new System.EventHandler(this.frmRegistrarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.ComboBox cmAsignarRoles;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblRolRegistrar;
        private System.Windows.Forms.Label lblContraseñaRegistrar;
        private System.Windows.Forms.Label lblCorreoRegistrar;
        private System.Windows.Forms.Label lblNombreRegistrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}
