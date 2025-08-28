using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class frmRegistrarUsuario : UserControl
    {
        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            cargarRoles();
        }
        private void cargarRoles() 
        {
            cmAsignarRoles.DataSource = null;
            cmAsignarRoles.DataSource = Usuario.cargarRoles();
            cmAsignarRoles.DisplayMember = "Nombre";
            cmAsignarRoles.ValueMember = "id";

        
        
        }




        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Nombre=txtNombre.Text;
            user.Email=txtCorreo.Text;
            user.Clave=BCrypt.Net.BCrypt.HashPassword(txtContra.Text);
            user.RolId = Convert.ToInt32(cmAsignarRoles.SelectedValue);

            if (user.RegistrarUsuario()==true)
            {
                MessageBox.Show("Usuario registrado, bienvenido "+user.Nombre);
            }


        }
    }
}
