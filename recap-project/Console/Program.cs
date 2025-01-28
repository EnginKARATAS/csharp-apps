using Business.Concrete;
using Dal.Abstract;
using Dal.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarDal memoryCarDal = new InMemoryCarDal();
            ICarDal sqlCarDal = new SqlCarDal();
            Car car1 = new Car { Description = "hell yea" };

            CarManager carManager = new CarManager(memoryCarDal);
            carManager.Delete(car1);

            //linq
            List<Car> cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=10,ModelYear=1998,Description="Bmw 1.16"},
                new Car{Id=2,BrandId=1,ColorId=1,DailyPrice=20,ModelYear=2002,Description="Mercedes C180"},
                new Car{Id=3,BrandId=1,ColorId=2,DailyPrice=35,ModelYear=2004,Description="xxVolvo"},
                new Car{Id=4,BrandId=2,ColorId=2,DailyPrice=40,ModelYear=2010,Description="xxRenault Hybrid"},
                new Car{Id=5,BrandId=2,ColorId=3,DailyPrice=50,ModelYear=2021,Description="Tesla"},
                new Car{Id=5,BrandId=2,ColorId=3,DailyPrice=150,ModelYear=2010,Description="Bmw 2010"},
                new Car{Id=5,BrandId=2,ColorId=1,DailyPrice=150,ModelYear=2021,Description="Bmw 2021"}
            };

            List<Color> colors = new List<Color> 
            {
                new Color{ColorId = 1, ColorName = "Blue"},
                new Color{ColorId = 2, ColorName = "Purple"},
                new Color{ColorId = 3, ColorName = "Purple"}
            };
            //result = Ienumarable<cardto>
            //before linq, we were making statement like this ⬇
            var result = from ca in cars
                         join co in colors
                         on ca.ColorId equals co.ColorId
                         select new CarDto{ ColorName = co.ColorName, Description=ca.Description };
            //Notice: select ---- statement represent a return object. here is cardto another way is : select ca.ProductName

            foreach (var item in result)
            {
                System.Console.WriteLine("{0} --- {1}", item.Description, item.ColorName);
            }
                          
            //ReturnBoolIfExist(dbMemory);

            //ReturnCarIfExist(dbMemory);

            //FindAllWithStatement(dbMemory);

            //AscDesc(cars);

        }

        private static void AscDesc(List<Car> cars)
        {
            var result = cars.Where(c => c.Id == 5).OrderByDescending(c => c.DailyPrice).ThenBy(c => c.ModelYear);
            foreach (var item in result)
            {
                System.Console.WriteLine(item.Description);
            }
        }

        private static void FindAllWithStatement(List<Car> cars)
        {
            //result is a list. Findall working like select-where tsql query
            var result = cars.FindAll(c => c.ColorId == 2 && c.Description.Contains("xx"));
            foreach (var item in result)
            {
                System.Console.WriteLine(item.Description);
            }
        }

        private static void ReturnCarIfExist(List<Car> cars)
        {
            //result type = Car. if statement true, gives that car
            //Find() = Where()
            var result = cars.Find(c => c.Id == 3);
            System.Console.WriteLine(result.Description);
        }

        private static void ReturnBoolIfExist(List<Car> cars)
        {
            var result = cars.Any(c => c.Id == 5);
            System.Console.WriteLine(result);
        }
    }
}