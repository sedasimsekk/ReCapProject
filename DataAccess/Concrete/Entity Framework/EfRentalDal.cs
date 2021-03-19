using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapContext context=new ReCapContext())
            {
                var result = from r in context.Rentals 
                             join c in context.Cars 
                             on r.CarId equals c.Id 
                             join b in context.Brand
                             on c.BrandId equals b.Id
                             join co in context.Colors 
                             on c.ColorId equals co.Id 
                             join cu in context.Customers
                             on r.CustomerId equals cu.CustomerId 
                             join u in context.Users 
                             on cu.UserId equals u.UserId
                             select new RentalDetailDto 
                             {
                                 IdRental=r.RentalId,
                                 IdCar=c.Id,
                                 IdCustomer=cu.CustomerId,
                                 RenterLastName=u.LastName,
                                 RenterFirstName=u.FirstName,
                                 CarBrandName=b.BrandName,
                                 CarColorName=co.ColorName,
                                 RenterCompanyName=cu.CompanyName,
                                 CarDailyPrice=c.DailyPrice,
                                 RentalRentDate=r.RentDate,
                                 RentalReturnDate=r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
