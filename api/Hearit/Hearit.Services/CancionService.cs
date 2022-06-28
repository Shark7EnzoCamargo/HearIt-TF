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
    public class CancionService : ICancionService
    {
        private readonly HearitDbContext _context;

        public CancionService(HearitDbContext context)
        {
            this._context = context;
        }

        public async Task<Cancion> CreateCancion(Cancion cancion)
        {
            await _context.Cancions.AddAsync(cancion);
            await _context.SaveChangesAsync();

            return cancion;
        }

        public async Task DeleteCancion(Cancion cancion)
        {
            _context.Cancions.Remove(cancion);
            await _context.SaveChangesAsync();
        }

        public async Task<Cancion> GetCancion(int id)
        {
            return await _context.Cancions.Where(g => g.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Cancion>> GetCancions()
        {
            return await _context.Cancions.ToListAsync();
        }

        public async Task UpdateCancion(Cancion cancion)
        {
            _context.Entry(cancion).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

    }
}
