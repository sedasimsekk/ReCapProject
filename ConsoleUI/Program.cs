using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());


            foreach (var car in carManager.GetCarsByColorId(2)) //bize gönderilen listeyi ekranda göstermek için kullanıyoruz.
            {
                Console.WriteLine(car.ColorId);
            }
            //eğer araç isim uzunluğu iki karakterden fazlaysa ve ücreti 0 dan fazlaysa ekledi mesajı değil ise eklemedi mesajı verecektir.
            Console.WriteLine(carManager.Added(new Car { Id=6,CarName = "Günlük Araç", BrandId = 4, ColorId = 3, ModelYear = 2004, DailyPrice = 200, Description = "araç kiralıktır" }));
        }
    }
}
