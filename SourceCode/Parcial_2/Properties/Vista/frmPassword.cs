using System;
using System.Windows.Forms;
using Parcial_2.Properties.Controladores;
using Parcial_2.Properties.Modelos;

namespace Parcial_2.Properties.Vista
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
            
        }
        private void frmPassword_Load(object sender, EventArgs e)
        {
            ActualizarControles();
        }
        private void ActualizarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "Contrasena";
            comboBox1.DisplayMember = "NombreUsuario";
            comboBox1.DataSource = UsuarioC.GetUsuarios();
        }


        private void bttnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text.Equals(comboBox1.SelectedValue.ToString()))
            {
                var obtenerUsuario = (Usuario) comboBox1.SelectedItem;
                
                UsuarioC.ActualizarContrasena(obtenerUsuario.NombreUsuario,
                    txtNewPassword.Text);

                ActualizarControles();
            }
            else
            {
                MessageBox.Show("Contrasena incorrecta");
            }
        
        }
    }
}