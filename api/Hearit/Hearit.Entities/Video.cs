
using System.ComponentModel.DataAnnotations;

namespace Hearit.Entities
{
    public class Video : EntityBase
    {
        public int Id { get; set; }
        public int ArtistaId { get; set; }
        public Nuevo_Artista Artista { get; set; }

        [StringLength(50)]
        [Required]
        public string Titulo { get; set; }

        [StringLength(100)]
        [Required]
        public string Descripcion { get; set; }
        public string? VideoURL { get; set; }
    }
}
