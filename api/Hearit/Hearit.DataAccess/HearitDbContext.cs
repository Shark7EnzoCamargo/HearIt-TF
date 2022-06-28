using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Hearit.Entities;

namespace Hearit.DataAccess;

public class HearitDbContext : DbContext
{
    public HearitDbContext()
    {

    }
    public HearitDbContext(DbContextOptions<HearitDbContext> options) : base(options)
    {

    }

    public DbSet<Busqueda_Cancion> Busqueda_Cancions { get; set; }
    public DbSet<Calificacion> Calificacions { get; set; }
    public DbSet<Cancion> Cancions { get; set; }
    public DbSet<Nuevo_Artista> Artistas { get; set; }
    public DbSet<Nuevo_Usuario> Usuarios { get; set; }
    public DbSet<PlayList> PlayLists { get; set; }
    public DbSet<Video> Videos { get; set; }

}

