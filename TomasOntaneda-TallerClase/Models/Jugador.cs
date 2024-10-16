using System.ComponentModel.DataAnnotations;

namespace TomasOntaneda_TallerClase.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Posicion { get; set; }
        public int Edad { get; set; }
        public Equipo Equipo { get; set; }
    }
}
