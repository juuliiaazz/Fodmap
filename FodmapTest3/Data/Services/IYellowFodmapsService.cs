using FodmapTest3.Models;

namespace FodmapTest3.Data.Services
{
    public interface IYellowFodmapsService
    {
        Task<IEnumerable<YellowFodmap>> GetAllAsync();
    }
}
