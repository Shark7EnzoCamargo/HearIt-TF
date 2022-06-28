using Hearit.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearit.Services
{
    public interface ICancionService
    {
        Task<Cancion> CreateCancion(Cancion cancion);
        Task DeleteCancion(Cancion cancion);
        Task<Cancion> GetCancion(int id);
        Task<List<Cancion>> GetCancions();
        Task UpdateCancion(Cancion cancion);

    }
}
