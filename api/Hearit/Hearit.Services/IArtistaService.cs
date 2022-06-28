using Hearit.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearit.Services
{
    public interface IArtistaService
    {
        Task<Nuevo_Artista> CreateArtista(Nuevo_Artista artista);
        Task DeleteArtista(Nuevo_Artista artista);
        Task<Nuevo_Artista> GetArtista(int id);
        Task<List<Nuevo_Artista>> GetArtistas();
        Task UpdateArtista(Nuevo_Artista artista);

    }
}
