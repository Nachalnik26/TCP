using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebApp_1.Data.Models;

namespace TestWebApp_1.Data.Interfaces
{
    interface IVideosCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
