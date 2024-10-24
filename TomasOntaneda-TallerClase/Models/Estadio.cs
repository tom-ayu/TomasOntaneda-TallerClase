using System.ComponentModel.DataAnnotations;

namespace TomasOntaneda_TallerClase.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public int Capacidad { get; set; }
    }
}
