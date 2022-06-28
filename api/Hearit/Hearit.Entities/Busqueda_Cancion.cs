
namespace Hearit.Entities
{
    public class Busqueda_Cancion : EntityBase
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }
        public Nuevo_Usuario Usuario { get;set; }

        public int CancionId { get; set; } 
        public Cancion Cancion { get; set; }
    }
}
