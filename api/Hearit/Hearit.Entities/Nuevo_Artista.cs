
using System.ComponentModel.DataAnnotations;

namespace Hearit.Entities

{
    public class Nuevo_Artista : EntityBase 
    {
        public int Id { get; set; }

        [StringLength(25)]
        [Required]
        public string Nombre { get; set; }

        [StringLength(25)]
        [Required]
        public string Apellido { get; set; }

        [StringLength(50)]
        [Required]
        public string Correo { get; set; }

        public bool Premium { get; set; }

        [StringLength(25)]
        [Required]
        public string Genero { get; set; }

        [StringLength(100)]
        [Required]
        public string Descripcion { get; set; }
    }
}
