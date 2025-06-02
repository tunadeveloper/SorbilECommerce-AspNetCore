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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void DeleteBL(Contact t)
        {
            _contactDal.Delete(t);
        }

        public Contact GetByIdBL(int id)
        {
           return _contactDal.GetById(id);
        }

        public List<Contact> GetListBL()
        {
           return _contactDal.GetList();
        }

        public void InsertBL(Contact t)
        {
           _contactDal.Insert(t);
        }

        public void UpdateBL(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
