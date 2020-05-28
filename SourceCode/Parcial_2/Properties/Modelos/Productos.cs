namespace Parcial_2.Properties.Modelos
{
    public class Productos
    {
        public string IdProducto { get; set; }

        public string IdNegocio { get; set; }

        public string name { get; set; }

        public Productos(string idProducto, string idNegocio, string name)
        {
            IdProducto = idProducto;
            IdNegocio = idNegocio;
            this.name = name;
        }
    }
}