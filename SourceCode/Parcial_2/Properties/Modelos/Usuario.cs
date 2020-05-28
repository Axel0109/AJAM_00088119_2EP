namespace Parcial_2.Properties.Modelos
{
    public class Usuario
    {
        public string IdUsuario { get; set; } 
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public bool Admin { get; set; }
        public Usuario(string idUsuario, string nombreUsuario, string contrasena, bool admin)
        {
            IdUsuario = idUsuario;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            Admin = admin;
        }
    
    }
}