﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal: IGenericDal<EntityLayer.Concrete.Product>
    {
        List<Product> GetProductWithCategory();
        List<Product> GetProductsByCategoryId(int id);
    }
}
