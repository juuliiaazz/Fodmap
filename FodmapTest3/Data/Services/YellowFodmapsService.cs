using FodmapTest3.Models;
using Microsoft.EntityFrameworkCore;

namespace FodmapTest3.Data.Services
{
    public class YellowFodmapsService : IYellowFodmapsService
    {
        private readonly FodmapDbContext _context;

        public YellowFodmapsService(FodmapDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<YellowFodmap>> GetAllAsync()
        {
            var result = await _context.YellowFodmaps.ToListAsync();
            return result;
        }
    }
}
