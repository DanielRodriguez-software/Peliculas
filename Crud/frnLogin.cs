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
    public partial class frnLogin : UserControl
    {
        public frnLogin()
        {
            InitializeComponent();
        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //validamos que los compos no esten vacios


            if (!(string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtContra.Text)))
            {
                string clave = txtContra.Text;
                string correo=txtCorreo.Text;
                //en el if(==) no necesito comparar ya que implicitamente
                //estamos diciendo que si da verdadero lo que retorne la funcion
                //mostrar el mensaje y abrira el dashboard
                
                Usuario usuario = new Usuario();
                
                
                if (usuario.VerificarLogin(correo,clave)) 
                {
                    MessageBox.Show("Inicio de sesion exitoso");
                    //crear un formulario llamdo dashboard
                    frmPeliculas peliculas = new frmPeliculas();
                    peliculas.Show();
                    //crontrolando y cerrando el fromulario
                    Form parentform=this.FindForm();
                    if (parentform != null) 
                    { 
                    parentform.Hide();


                    }
                    else 
                    {

                        MessageBox.Show("Datos incorrectos");
                    
                    
                    }

                
                }





            }
            else 
            {

                MessageBox.Show("Por favor llena los campos requeridos");
            
            }
        }
    }
}
