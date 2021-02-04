using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Car car1 = new Car { CarId = 1, BrandId = 1, CarModelYear = 2021, ColorId = 3, CarDailyPrice = 500, CarDescription = "Elegante Sedan Hibrit ES" };
            Car car2 = new Car { CarId = 2, BrandId = 1, CarModelYear = 2021, ColorId = 7, CarDailyPrice = 300, CarDescription = "Elegante Sedan Hibrit ED" };
            //carManager.Delete(car1);
            //carManager.Add(car1);
            //carManager.Add(car2);

            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.CarDescription);
            }
            
        }
    }
}
