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
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2000,DailyPrice=10000,Description="Sadece günübirlik"},
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear=2000,DailyPrice=30000,Description="Uygundur"},
                new Car{Id=3,BrandId=1,ColorId=2,ModelYear=2001,DailyPrice=50000,Description="Kaza bedeli size aittir"},
                new Car{Id=4,BrandId=2,ColorId=3,ModelYear=2002,DailyPrice=92000,Description="Kaza olursa karşılıyoruz"},
                new Car{Id=5,BrandId=2,ColorId=3,ModelYear=2002,DailyPrice=180000,Description="Memnuniyetiniz mutluluğumuzdur"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car); //eklendi
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(_cars => _cars.Id == car.Id); //linq kullanarak silinmek istenen arabanın referansını bulduk.
            _cars.Remove(CarToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars; //bir liste geri gönderdik.
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(_cars => _cars.Id == Id).ToList(); //Id'ye göre listeleme yaptık ve bu listeyi çağırılan yere gönderdik.
        }

        public void UpDate(Car car)
        {
            Car CarToUpDate = _cars.SingleOrDefault(_cars => _cars.Id == car.Id); //linq kullanarak güncellenmek istenen arabanın referansını bulduk.
            CarToUpDate.Id = car.Id;
            CarToUpDate.BrandId = car.BrandId;
            CarToUpDate.ColorId = car.ColorId;
            CarToUpDate.ModelYear = car.ModelYear;
            CarToUpDate.DailyPrice = car.DailyPrice;
            CarToUpDate.Description = car.Description; //ve bize gönderilen değerler ile güncellenmek istenen yeri ona göre güncelledik.
        }
    }
}
