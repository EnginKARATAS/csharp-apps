using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Abstract
{
    public interface ICarDal
    {
        Car GetById();
        List<Car> GetAll();
 
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
