using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Parcial_2.Properties.Controladores;
using Parcial_2.Properties.Modelos;

namespace Parcial_2.Properties.Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            poblarControles();
        }

        private void poblarControles()
        {
            cmbUser.DataSource = null;
            cmbUser.ValueMember = "Contrasena";
            cmbUser.DisplayMember = "NombreUsuario";
            cmbUser.DataSource = UsuarioC.GetUsuarios();
        }
        private void bttnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(cmbUser.SelectedValue.ToString()))
            {
                frmMain FrmMain = new frmMain((Usuario) cmbUser.SelectedItem);
                Hide();
                FrmMain.Show();
            }
            else
            {
                MessageBox.Show("Contrasena incorrecta");
            }
            
        }
        private void bttnUpdatePassword_Click(object sender, EventArgs e)
        {
            frmPassword frmPassword = new frmPassword();
            frmPassword.Show();
        }
    }
}