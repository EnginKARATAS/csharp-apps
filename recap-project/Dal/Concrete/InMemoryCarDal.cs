using Dal.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        Car car1;
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=10,ModelYear=1998,Description="Bmw 1.16"},
                new Car{Id=2,BrandId=1,ColorId=1,DailyPrice=20,ModelYear=2002,Description="Mercedes C180"},
                new Car{Id=3,BrandId=1,ColorId=2,DailyPrice=35,ModelYear=2004,Description="Volvo"},
                new Car{Id=4,BrandId=2,ColorId=2,DailyPrice=40,ModelYear=2010,Description="Renault Hybrid"},
                new Car{Id=5,BrandId=2,ColorId=3,DailyPrice=50,ModelYear=2021,Description="Tesla"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            foreach (var item in _cars)
            {
                if (item.Id == car.Id)
                {
                    car1 = new Car();
                    car1 = item;
                }
                    _cars.Remove(car1);
            }

        }

        public List<Car> GetAll()
        {
            Console.WriteLine("In memory classına göre dolduruldu işlem yapıldı get all çalıştı");
            return _cars;
        }

        public Car GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
