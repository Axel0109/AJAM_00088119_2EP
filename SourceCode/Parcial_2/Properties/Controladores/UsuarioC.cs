using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Parcial_2.Properties.Modelos;


namespace Parcial_2.Properties.Controladores
{
    public class UsuarioC
    {
        public static object GetUsuarios()
        {
            var usuarios = new List<Usuario>();
            DataTable TablaUsuarios = null;

            try
            {
                TablaUsuarios = BDconexion.ExecuteQuery("SELECT * FROM APPUSER");
            }
            catch
            {
                MessageBox.Show("ERROR");
            }

            if (TablaUsuarios != null)
                foreach (DataRow dr in TablaUsuarios.Rows)
                {
                    usuarios.Add(new Usuario
                        (
                            dr[1].ToString(),
                            dr[2].ToString(),
                            dr[3].ToString(),
                            Convert.ToBoolean(dr[4].ToString())
                        )
                    );
                }

            return usuarios;
        }
        public static DataTable GetTablaUsuario()
        {
            DataTable TablaUsuarios = null;

            try
            {
                TablaUsuarios = BDconexion.ExecuteQuery("SELECT * FROM APPUSER");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }

            return TablaUsuarios;
        }
        public static void ActualizarContrasena(string NombreUsuario, string nueva)
        {
            try
            {
                BDconexion.ExecuteQuery($"UPDATE APPUSER SET password = '{nueva}' " +
                                           $"WHERE username = '{NombreUsuario}'");

                MessageBox.Show("contraseña actualizada");
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        public static void CrearUsuario(string usuario)
        {
            try
            {
                BDconexion.ExecuteQuery("INSERT INTO APPUSER(fullname, password, usertype)" +
                                         $" VALUES('{usuario}', '{usuario}', false)");

                MessageBox.Show("Se agrego el nuevo usuario");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}