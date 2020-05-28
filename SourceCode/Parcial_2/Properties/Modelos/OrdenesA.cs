namespace Parcial_2.Properties.Modelos
{
    public class OrdenesA
    {
        public string IdOrden { get; set; }

        public string createData { get; set; }

        public string IdProducto { get; set; }

        public bool IdDireccion { get; set; }


        public OrdenesA(string idOrden, string data, string idProducto, bool idDireccion)
        {
            IdOrden = idOrden;
            createData = data;
            IdProducto = idProducto;
            IdDireccion = idDireccion;
        }
    }
}