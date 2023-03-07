using FodmapTest3.Models;
using Microsoft.EntityFrameworkCore;

namespace FodmapTest3.Data.Services
{
    public class ArticlesService : IArticlesService
    {
        private readonly FodmapDbContext _context;

        public ArticlesService(FodmapDbContext context)
        {
            _context = context;
        }
        public void Add(Article article)
        {
            _context.Articles.Add(article);
            _context.SaveChanges();
        }

        public void Delete(string gtin)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Article>> GetAllAsync()
        {
            var result = await _context.Articles.ToListAsync();
            return result;
        }

        public async Task<Article> GetByIdAsync(string gtin)
        {
            var result = await _context.Articles.FirstOrDefaultAsync(n => n.Gtin == gtin);
            return result;
        }

       

        public Article Update(string gtin, Article newArticle)
        {
            throw new NotImplementedException();
        }
    }
}
