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
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void DeleteBL(Blog t)
        {
            _blogDal.Delete(t);
        }

        public Blog GetByIdBL(int id)
        {
           return _blogDal.GetById(id);
        }

        public List<Blog> GetListBL()
        {
           return _blogDal.GetList();
        }

        public void InsertBL(Blog t)
        {
          _blogDal.Insert(t);
        }

        public void UpdateBL(Blog t)
        {
           _blogDal.Update(t);
        }
    }
}
