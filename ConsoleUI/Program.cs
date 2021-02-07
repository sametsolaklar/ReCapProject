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
            Color color1 = new Color { ColorId = 11, ColorName = "Dark Blue" };
            Color color2 = new Color { ColorId = 12, ColorName = "Dark Grey" };
            Color color3 = new Color { ColorId = 13, ColorName = "Light Red" };
            //ColorAdd(color1);
            //ColorAdd(color2);
            //ColorAdd(color3);
            //ColorDelete(color1);
            Brand brand1 = new Brand { BrandId = 11, BrandName = "BMW" };
            Brand brand2 = new Brand { BrandId = 12, BrandName = "Mercedes" };
            Brand brand3 = new Brand { BrandId = 13, BrandName = "Audi" };
            //BrandAdd(brand1);
            //BrandAdd(brand2);
            //BrandAdd(brand3);
            //BrandDelete(brand3);

            Car car1 = new Car { CarId = 4, BrandId = 11, CarModelYear = 2020, ColorId = 11, CarDailyPrice = 300, CarDescription = "BMW 340i M Sport 2020" };
            Car car2 = new Car { CarId = 5, BrandId = 12, CarModelYear = 2020, ColorId = 12, CarDailyPrice = 300, CarDescription = "Mercedes AMG CLA 45s 4MATIC" };
            Car car3 = new Car { CarId = 6, BrandId = 13, CarModelYear = 2020, ColorId = 13, CarDailyPrice = 350, CarDescription = "Audi RS6" };
            //CarAdd(car1);
            //CarAdd(car2);
            //CarAdd(car3);
            //CarDelete(car1);
            //CarDelete(car2);
            //CarDelete(car3);


            //ColorTest();

            //BrandTest();

            CarTest();

        }

        private static void BrandDelete(Brand brand)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(brand);
        }

        private static void BrandAdd(Brand brand)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(brand);
        }

        private static void ColorDelete(Color color)
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Delete(color);
        }

        private static void ColorAdd(Color color)
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(color);
        }

        private static void CarDelete(Car car)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(car);
        }

        private static void CarAdd(Car car)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car);
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarDescription + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice );
            }
        }
    }
}
