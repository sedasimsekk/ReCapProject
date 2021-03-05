using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (ReCapContext context=new ReCapContext()) //bellekte hızlı temizleme yapar 
            {
                var addedEntity = context.Entry(entity); //aldığımız nesnenin veri tabanı ile ilişkisini kurduk
                addedEntity.State =EntityState.Added; //ilişkisini kurduğumuz nesnenin ne yaptığını soyluyoruz.
                context.SaveChanges(); //ekleme işlemi yapar
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapContext context = new ReCapContext()) //bellekte hızlı temizleme yapar 
            {
                var deletedEntity = context.Entry(entity); //aldığımız nesnenin veri tabanı ile ilişkisini kurduk
                deletedEntity.State = EntityState.Deleted; //ilişkisini kurduğumuz nesnenin ne yaptığını soyluyoruz.
                context.SaveChanges(); // silme işlemi yapar
            }

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapContext context=new ReCapContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);

            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapContext context=new ReCapContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();

            }
        }

        public void UpDate(Car entity)
        {
            using (ReCapContext context = new ReCapContext()) //bellekte hızlı temizleme yapar 
            {
                var updatedEntity = context.Entry(entity); //aldığımız nesnenin veri tabanı ile ilişkisini kurduk
                updatedEntity.State = EntityState.Modified; //ilişkisini kurduğumuz nesnenin ne yaptığını soyluyoruz.
                context.SaveChanges(); // güncelleme işlemi yapar
            }
        }
    }
}
