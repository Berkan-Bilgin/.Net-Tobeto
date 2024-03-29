﻿using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetAllByCategoryId(int id);

        List<Product> GetByUnitPrice(decimal mini, decimal max);



    }
}
