﻿using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GeyById(int BrandID);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
