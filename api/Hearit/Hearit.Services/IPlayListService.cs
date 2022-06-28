using Hearit.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearit.Services
{
    public interface IPlayListService
    {
        Task<PlayList> CreatePlayList(PlayList playlist);
        Task DeletePlayList(PlayList playlist);
        Task<PlayList> GetPlayList(int id);
        Task<List<PlayList>> GetPlayLists();
        Task UpdatePlayList(PlayList playlist);

    }
}
