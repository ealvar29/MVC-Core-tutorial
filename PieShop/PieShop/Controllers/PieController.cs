using Microsoft.AspNetCore.Mvc;
using PieShop.Interface;
using PieShop.ViewModels;

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
            PiesListViewModel pieListViewModel = new PiesListViewModel();
            pieListViewModel.Pies = _pieRepository.AllPies;
            pieListViewModel.CurrentCategory = "Cheese cakes";
            return View(pieListViewModel);
        }
    }
}