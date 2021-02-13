using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join g in context.Customers
                             on r.CustomerId equals g.Id
                             select new RentalDetailDto
                             {
                                 CarDescription = c.CarDescription, CompanyName= g.CompanyName, DailyPrice = c.CarDailyPrice, RentalDate = r.RentDate 
                             };


                return result.ToList();


            }
        }
    }
}
