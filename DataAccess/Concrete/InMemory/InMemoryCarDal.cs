using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=120, ModelYear=2012, Description="Mercedes-Benz C180"},
                new Car{Id=2, BrandId=2, ColorId=3, DailyPrice=250, ModelYear=2015, Description="BMW 2 serisi 216d Gran Tourer"},
                new Car{Id=3, BrandId=1, ColorId=2, DailyPrice=200, ModelYear=2016, Description="Mercedes-Benz A180 AMG"},
                new Car{Id=4, BrandId=3, ColorId=4, DailyPrice=180, ModelYear=2015, Description="Audi A3 Sedan 1.6 TDI"},
                new Car{Id=5, BrandId=4, ColorId=1, DailyPrice=500, ModelYear=2018, Description="Mini Cooper 1.5 Chili"},
                new Car{Id=6, BrandId=2, ColorId=2, DailyPrice=330, ModelYear=2020, Description="BMW 8 serisi 840i xDrive M Sport"},
            };
        }
        
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=> c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

    }
}
