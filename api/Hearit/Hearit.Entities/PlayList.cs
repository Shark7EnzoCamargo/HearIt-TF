using System.ComponentModel.DataAnnotations;
namespace Hearit.Entities

{
    public class PlayList : EntityBase
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Nuevo_Usuario Usuario { get; set; }

        public int CancionId { get; set; } 
        public Cancion Cancion { get; set; }

        [StringLength(30)]
        [Required]
        public string Titulo { get; set; }

        [StringLength(100)]
        [Required]
        public string Descripcion { get; set; }
    }
}
