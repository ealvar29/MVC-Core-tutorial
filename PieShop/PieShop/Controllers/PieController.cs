using Microsoft.AspNetCore.Mvc;
using PieShop.Interface;

namespace PieShop.Controllers
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
        
        // GET
        public ViewResult List()
        {
            return View(_pieRepository.AllPies);
        }
    }
}