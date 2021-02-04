using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            var condition = car.CarDescription.Length;
            var condition2 = car.CarDailyPrice;
            if (condition2 > 0 && condition >2 )
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Koşullar yerine getirilmedi. Lütfen tekrar deneyin.");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c=>c.ColorId ==id);
        }

    }
}
