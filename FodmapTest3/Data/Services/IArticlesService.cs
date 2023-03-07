using FodmapTest3.Models;

namespace FodmapTest3.Data.Services
{
    public interface IArticlesService
    {
        Task <IEnumerable<Article>> GetAllAsync();

        Task<Article> GetByIdAsync(string gtin);

        void Add(Article article);

        Article Update(string gtin, Article newArticle);

        void Delete(string gtin);
    }
}
