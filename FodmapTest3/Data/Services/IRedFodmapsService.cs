using FodmapTest3.Models;

namespace FodmapTest3.Data.Services
{
    public interface IRedFodmapsService
    {
        Task <IEnumerable<RedFodmap>> GetAllAsync();


        Task<RedFodmap> GetByIdAsync(string id);

        void Add(RedFodmap redfodmap);

        RedFodmap Update(string id, RedFodmap newRedFodmap);

        void Delete(string id);
    }
}
