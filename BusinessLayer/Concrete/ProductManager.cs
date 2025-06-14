using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void DeleteBL(Product t)
        {
            _productDal.Delete(t);
        }

        public Product GetByIdBL(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> GetListBL()
        {
            return _productDal.GetList();
        }

        public List<Product> GetProductsByCategoryIdBL(int id)
        {
           return _productDal.GetProductsByCategoryId(id);
        }

        public List<Product> GetProductWithCategoryBL()
        {
            return _productDal.GetProductWithCategory();
        }

        public void InsertBL(Product t)
        {
           _productDal.Insert(t);
        }

        public void UpdateBL(Product t)
        {
           _productDal.Update(t);
        }
    }
}
