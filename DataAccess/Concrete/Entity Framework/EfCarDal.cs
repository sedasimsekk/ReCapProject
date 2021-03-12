using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context=new ReCapContext())  //hızlı temizleme işlemi 
            {
                var result = from c in context.Cars //Dto yaparak ilişkisel tabloları birleştirdik ve ekrana yazdırabileceğiz.
                             join co in context.Colors
                             on c.Id equals co.Id
                             join b in context.Brand
                             on c.Id equals b.Id
                             select new CarDetailDto 
                             { CarId = c.Id,CarName=c.CarName,ColorName = co.ColorName, BrandName = b.BrandName, DailyPrice = c.DailyPrice };
                return result.ToList();
            }
        }
    }
}
