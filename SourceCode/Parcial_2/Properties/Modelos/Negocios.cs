namespace Parcial_2.Properties.Modelos
{
    public class Negocios
    {
        public string IdNegocio { get; set; }
        public string Name { get; set; }
        public string Descripcion { get; set; }
        
        public Negocios(string idNegocio, string name, string descripcion)
        {
            IdNegocio = idNegocio;
            Name = name;
            Descripcion = descripcion;
        }
    }
    
    
    
}