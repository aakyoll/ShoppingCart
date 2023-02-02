using ShoppingCart.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repositories
{
    public class UnitofWork : IUnitofWork
    {
        private readonly ApplicationDbContext _context;

        public ICategoryRepository Categories { get; private set; }

        public IProductRepository Product { get; private set; }


        public UnitofWork(ApplicationDbContext context)
        {

            _context = context;
            Categories = new CategoryRepository(context);
            Product = new ProductRepository(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
