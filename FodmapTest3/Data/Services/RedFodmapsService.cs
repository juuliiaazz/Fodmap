using FodmapTest3.Models;
using Microsoft.EntityFrameworkCore;

namespace FodmapTest3.Data.Services
{
    public class RedFodmapsService : IRedFodmapsService
    {
        private readonly FodmapDbContext _context;

        public RedFodmapsService(FodmapDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RedFodmap>> GetAllAsync()
        {
            var result = await _context.RedFodmaps.ToListAsync();
            return result;
        }

        public void Add(RedFodmap redfodmap)
        {
            _context.RedFodmaps.Add(redfodmap);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }


        public async Task<RedFodmap> GetByIdAsync(string id)
        {
            var result = await _context.RedFodmaps.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }



        public RedFodmap Update(string id, RedFodmap newRedFodmap)
        {
            throw new NotImplementedException();
        }
    }
}
