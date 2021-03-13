using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.DataAccess.Entity;

namespace DrinkAndGo.DataAccess.Abstract
{
    public interface ICategoryRepository
    {
        IEnumerable<Category>Categories { get; }
    }
}
