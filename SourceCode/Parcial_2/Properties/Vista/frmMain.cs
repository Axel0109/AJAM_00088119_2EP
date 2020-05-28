using System;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using Parcial_2.Properties.Controladores;
using Parcial_2.Properties.Modelos;

namespace Parcial_2.Properties.Vista
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Usuario u;
        private Direcciones d;

        public frmMain(Direcciones d)
        {
            this.d = d;
            InitializeComponent();
        }

        public frmMain(Usuario u)
        {
            InitializeComponent();
            this.u = u;
        }

        

        private void bttnCreateUser_Click(object sender, EventArgs e)
        {
            if (!txtagfullname.Text.Equals("") ||
                !txtagpassword.Text.Equals("") ||
                !txtagusername.Text.Equals("") ||
                !txtagusertype.Text.Equals(""))
            {try
                {
                    BDconexion.ExecuteNonQuery($"INSERT INTO APPUSER(fullname, username, password, userType) VALUES(" +
                                                 $"'{txtagfullname.Text}'," +
                                                 $"'{txtagusername.Text}'," +
                                                 $"'{txtagpassword.Text}'," +
                                                 $"'{txtagusertype.Text}')");
                    MessageBox.Show("Se ha ingresado usuario");
                    ActualizarCrearUsuario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
            else
            {
                MessageBox.Show("no se pueden dejar campos vacios");
            }
        }
        
        
        private void ActualizarCrearUsuario()
        {
            dgvUser.DataSource = UsuarioC.GetTablaUsuario();
        }
        private void ActualizarCrearDireccion()
        {
            dgvDirecciones.DataSource = DireccionesC.GetTablaDirecciones();
        }

        private void bttnDeletUser_Click(object sender, EventArgs e)
        {
            if (!textDeleteUser.Text.Equals(""))
            {
                try
                {
                    BDconexion.ExecuteNonQuery($"DELETE FROM APPUSER WHERE username = '{textDeleteUser.Text}'");
                    MessageBox.Show("se ha eliminado el usuario");
                    ActualizarCrearUsuario();
                }
                catch
                {
                    MessageBox.Show("ERROR");
                }
            }
            else
            {
                MessageBox.Show("campo vacio");
            }
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            ActualizarControles();
        }
        private void ActualizarControles()
        {
            cmbUserd.DataSource = null;
            cmbUserd.DisplayMember = "Direccion";
            cmbUserd.DataSource = DireccionesC.GetDirecciones();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (!txtaggdireccion.Text.Equals(""))
            {
                try
                {
                    BDconexion.ExecuteNonQuery($"INSERT INTO ADDRESS(IDUSER, IDADDRESS, ADDRESS)" +
                                               $"'{txtaggdireccion}',");
                    MessageBox.Show("Se ha ingresado la direccion");
                    ActualizarCrearDireccion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
            else
            {
                MessageBox.Show("campo vacio");
            }
        }
    }
}
