﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void DeleteBL(About t)
        {
          _aboutDal.Delete(t);
        }

        public About GetByIdBL(int id)
        {
           return _aboutDal.GetById(id);
        }

        public List<About> GetListBL()
        {
           return _aboutDal.GetList();
        }

        public void InsertBL(About t)
        {
           _aboutDal.Insert(t);
        }

        public void UpdateBL(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
