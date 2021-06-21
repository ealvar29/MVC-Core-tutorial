using System.Collections.Generic;
using PieShop.Interface;
using PieShop.Models;

namespace PieShop.Repository
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category {CategoryId = 1, CategoryName = "Fruit Pies", Description = "All-Fruit Pie!" },
                new Category {CategoryId = 2, CategoryName = "Fruit Pies", Description = "All-Fruit Pie!" },
                new Category {CategoryId = 1, CategoryName = "Fruit Pies", Description = "All-Fruit Pie!" }
            };
    }
}