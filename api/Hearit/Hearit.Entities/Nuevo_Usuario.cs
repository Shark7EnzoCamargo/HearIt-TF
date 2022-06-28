using System.ComponentModel.DataAnnotations;
namespace Hearit.Entities

{
    public class Nuevo_Usuario : EntityBase
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

    }
}
