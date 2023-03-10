using FodmapTest3.Data.Services;
using FodmapTest3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FodmapTest3.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly IArticlesService _service;

        public ArticlesController(IArticlesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

       // Get: Articles/Details/Id
       
        public async Task<IActionResult> Details(string gtin)
        {
            var articleDetails = await _service.GetByIdAsync(gtin);


            if (articleDetails == null) return View("NotFound");
            return View(articleDetails);
        }

       // Sökruta på startsidan
        public async Task<IActionResult> Filter(string searchString)
        {
            var allArticles = await _service.GetAllAsync();

            if (!string.IsNullOrEmpty(searchString))
            {

                var filteredResultNew = allArticles.Where(n => n.Varumarke.ToLower().Contains(searchString.ToLower()) ||
                n.Gtin.ToLower().Contains(searchString.ToLower()) ||
                n.Hyllkantstext.ToLower().Contains(searchString.ToLower())).ToList();

                return View("Index", filteredResultNew);
            }

            return View("Index", allArticles);
        }


        // Get: Articles/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Gtin,PictureUrl,Hyllkantstext,Ingrediensforteckning,Varumarke,RedFodmap,YellowFodmap")]Article article)
        {
            if(!ModelState.IsValid)
            {
                return View(article);
            }
            
            _service.Add(article);
            return RedirectToAction("Index");
        }
    }
}
