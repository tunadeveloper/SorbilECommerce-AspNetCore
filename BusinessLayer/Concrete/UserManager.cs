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
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void DeleteBL(User t)
        {
            _userDal.Delete(t);
        }

        public User GetByIdBL(int id)
        {
            return _userDal.GetById(id);
        }

        public List<User> GetListBL()
        {
            return _userDal.GetList();
        }

        public void InsertBL(User t)
        {
            _userDal.Insert(t);
        }

        public void UpdateBL(User t)
        {
           _userDal.Update(t);
        }
    }
}
