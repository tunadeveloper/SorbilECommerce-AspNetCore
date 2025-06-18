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
    public class NewsletterManager : INewsletterService
    {
        private readonly INewsletterDal _newsletterDal;

        public NewsletterManager(INewsletterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }

        public void DeleteBL(Newsletter t)
        {
           _newsletterDal.Delete(t);
        }

        public Newsletter GetByIdBL(int id)
        {
           return _newsletterDal.GetById(id);
        }

        public List<Newsletter> GetListBL()
        {
            return _newsletterDal.GetList();
        }

        public void InsertBL(Newsletter t)
        {
          _newsletterDal.Insert(t);
        }

        public void UpdateBL(Newsletter t)
        {
            _newsletterDal.Update(t);
        }
    }
}
