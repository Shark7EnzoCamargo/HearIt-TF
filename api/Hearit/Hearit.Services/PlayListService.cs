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
    public class PlayListService : IPlayListService
    {
        private readonly HearitDbContext _context;

        public PlayListService(HearitDbContext context)
        {
            this._context = context;
        }

        public async Task<PlayList> CreatePlayList(PlayList playlist)
        {
            await _context.PlayLists.AddAsync(playlist);
            await _context.SaveChangesAsync();

            return playlist;
        }

        public async Task DeletePlayList(PlayList playlist)
        {
            _context.PlayLists.Remove(playlist);
            await _context.SaveChangesAsync();
        }

        public async Task<PlayList> GetPlayList(int id)
        {
            return await _context.PlayLists.Where(g => g.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<PlayList>> GetPlayLists()
        {
            return await _context.PlayLists.ToListAsync();
        }

        public async Task UpdatePlayList(PlayList playlist)
        {
            _context.Entry(playlist).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

    }
}
