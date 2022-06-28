using Hearit.DataAccess;
using Hearit.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearit.Services
{
    public class ArtistaService : IArtistaService
    {
        private readonly HearitDbContext _context;

        public ArtistaService(HearitDbContext context)
        {
            this._context = context;
        }

        public async Task<Nuevo_Artista> CreateArtista(Nuevo_Artista artista)
        {
            await _context.Artistas.AddAsync(artista);
            await _context.SaveChangesAsync();

            return artista;
        }

        public async Task DeleteArtista(Nuevo_Artista artista)
        {
            _context.Artistas.Remove(artista);
            await _context.SaveChangesAsync();
        }

        public async Task<Nuevo_Artista> GetArtista(int id)
        {
            return await _context.Artistas.Where(g => g.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Nuevo_Artista>> GetArtistas()
        {
            return await _context.Artistas.ToListAsync();
        }

        public async Task UpdateArtista(Nuevo_Artista artista)
        {
            _context.Entry(artista).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

    }
}
