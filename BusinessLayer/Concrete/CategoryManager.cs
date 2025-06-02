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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void DeleteBL(Category t)
        {
            _categoryDal.Delete(t);
        }

        public Category GetByIdBL(int id)
        {
           return _categoryDal.GetById(id);
        }

        public List<Category> GetListBL()
        {
           return _categoryDal.GetList();
        }

        public void InsertBL(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void UpdateBL(Category t)
        {
           _categoryDal.Update(t);
        }
    }
}
