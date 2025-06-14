using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(Context context) : base(context)
        {
        }

        public List<Product> GetProductWithCategory()
        {
            Context _context = new Context();
            return _context.Products.Include(x=> x.Category).ToList();
        }

        public List<Product> GetProductsByCategoryId(int id)
        {
            Context _context = new Context();
            return _context.Products
                .Where(x=>x.CategoryId == id)
                .Include(x=>x.Category)
                .ToList();
        }
    }
}
