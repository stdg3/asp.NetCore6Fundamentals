using Microsoft.AspNetCore.Mvc;
using bethanysPieShop.Models;
using bethanysPieShop.ViewModel;

namespace bethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;   
        }

        public IActionResult List()
        {
            //return View(_pieRepository.AllPies);
            PieListViewModel pieListViewModel = new PieListViewModel(_pieRepository.AllPies, "somedata");
            return View(pieListViewModel);
            
        }
    }
}
