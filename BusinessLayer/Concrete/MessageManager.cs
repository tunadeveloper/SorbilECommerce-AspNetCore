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
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void DeleteBL(Message t)
        {
            _messageDal.Delete(t);
        }

        public Message GetByIdBL(int id)
        {
           return _messageDal.GetById(id);
        }

        public List<Message> GetListBL()
        {
          return _messageDal.GetList();
        }

        public void InsertBL(Message t)
        {
          _messageDal.Insert(t);
        }

        public void UpdateBL(Message t)
        {
         _messageDal.Update(t);
        }
    }
}
