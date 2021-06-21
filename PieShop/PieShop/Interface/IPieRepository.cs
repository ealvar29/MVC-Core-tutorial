using System.Collections;
using System.Collections.Generic;
using PieShop.Models;

namespace PieShop.Interface
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }

        IEnumerable<Pie> PiesOfTheWeek { get; }

        Pie GetPieById(int pieId);
    }
}