using System.ComponentModel.DataAnnotations;
namespace Hearit.Entities

{
    public class Cancion : EntityBase
    {
        public int Id { get; set; }

        [StringLength(25)]
        [Required]
        public string Nombre { get; set; }  

    }
}
