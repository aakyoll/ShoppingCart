using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repositories
{
    public interface IUnitofWork
    {
        ICategoryRepository Categories { get; }

        IProductRepository Product { get; }

        void Save();
    }
}
