using FodmapTest3.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace FodmapTest3.Controllers
{
    public class YellowFodmapsController : Controller
    {
        private readonly IYellowFodmapsService _service;

        public YellowFodmapsController(IYellowFodmapsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

      

    }
}
