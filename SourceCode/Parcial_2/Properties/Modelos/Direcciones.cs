using System;
using System.Windows.Forms;
using Parcial_2.Properties.Controladores;

namespace Parcial_2.Properties.Modelos
{
    public class Direcciones
    {
        public string IdUsuario { get; set; }
        
        public string IdDireccion { get; set; }

        public string Direccion { get; set; }

        public Direcciones(string idUsuario, string idDireccion, string direccion)
        {
            IdUsuario = idUsuario;
            IdDireccion = idDireccion;
            Direccion = direccion;
        }
    }
}