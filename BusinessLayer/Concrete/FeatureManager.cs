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
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _fetureDal;

        public FeatureManager(IFeatureDal fetureDal)
        {
            _fetureDal = fetureDal;
        }

        public void DeleteBL(Feature t)
        {
           _fetureDal.Delete(t);
        }

        public Feature GetByIdBL(int id)
        {
          return _fetureDal.GetById(id);
        }

        public List<Feature> GetListBL()
        {
          return _fetureDal.GetList();
        }

        public void InsertBL(Feature t)
        {
           _fetureDal.Insert(t);
        }

        public void UpdateBL(Feature t)
        {
          _fetureDal.Update(t);
        }
    }
}
