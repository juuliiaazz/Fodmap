using FodmapTest3.Data.Services;
using FodmapTest3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FodmapTest3.Controllers
{
    public class RedFodmapsController : Controller
    {
        private readonly IRedFodmapsService _service;

        public RedFodmapsController(IRedFodmapsService service)
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
