using System.Collections.Generic;
using System.Linq;
using PieShop.Interface;
using PieShop.Models;

namespace PieShop.Repository
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies =>
        new List<Pie>
        {
            new Pie
            {
                Id = 1, Name = "Strawberry Pie", Price = 15.95M,
                ShortDescription = "Cotton candy croissant bonbon lemon drops",
                LongDescription =
                    "Cotton candy croissant bonbon lemon drops candy canes chocolate bar. Carrot cake cupcake sweet. Sweet bonbon pastry donut jelly-o fruitcake tart"
            },
            new Pie
            {
                Id = 2, Name = "Cheese Cake", Price = 15.95M,
                ShortDescription = "Cotton candy croissant bonbon lemon drops",
                LongDescription =
                    "Cotton candy croissant bonbon lemon drops candy canes chocolate bar. Carrot cake cupcake sweet. Sweet bonbon pastry donut jelly-o fruitcake tart"
            },
            new Pie
            {
                Id = 3, Name = "Apple Pie", Price = 15.95M,
                ShortDescription = "Cotton candy croissant bonbon lemon drops",
                LongDescription =
                    "Cotton candy croissant bonbon lemon drops candy canes chocolate bar. Carrot cake cupcake sweet. Sweet bonbon pastry donut jelly-o fruitcake tart"
            },
        };
        public IEnumerable<Pie> PiesOfTheWeek { get; }
        
        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}