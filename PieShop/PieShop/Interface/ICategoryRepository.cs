using System.Collections;
using System.Collections.Generic;
using PieShop.Models;

namespace PieShop.Interface
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}