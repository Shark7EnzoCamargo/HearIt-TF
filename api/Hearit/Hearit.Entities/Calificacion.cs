using System.ComponentModel.DataAnnotations;
namespace Hearit.Entities

{
   public class Calificacion : EntityBase
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Nuevo_Usuario Usuario { get; set; }

        public int ArtistaId { get; set; }
        public Nuevo_Artista Artista { get; set; }

        public int Puntuacion { get; set; }
        [StringLength(100)]
        [Required]
        public string Comentario { get; set; }
    }
}
