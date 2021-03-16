﻿using Business.Concrete;
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
            //CarTest(); //burada extract method içinde car manager kısmı için olanlar var 
            //ColorTest(); //burada color manager kısmı için olanlar var 
            //BrandTest(); //burada car manager kısmı için olanlar var 
            //CarDetails(); //burada car details kısmı için olanlar var 
            

        }

        private static void CarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if(result.Success==true)
            {
                foreach (var car in result.Data) //bize gönderilen listeyi ekranda göstermek için kullanıyoruz.
                {
                    Console.WriteLine(car.CarName + " " + car.ColorName + " " + car.BrandName + " " + car.DailyPrice);
                }
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.BrandName);

            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetCarsByColorId(1);
            foreach (var color in result.Data) //colorId si 1 olanın ismini getirecek.
            {
                Console.WriteLine(color.ColorName);

            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();
            foreach (var car in result.Data) //bize gönderilen listeyi ekranda göstermek için kullanıyoruz.
            {
                Console.WriteLine(car.CarName);
            }
            //eğer araç isim uzunluğu iki karakterden fazlaysa ve ücreti 0 dan fazlaysa ekledi mesajı değil ise eklemedi mesajı verecektir.
            var resultt = carManager.Added(new Car { Id = 12, CarName = "Günlük Araç", BrandId = 4, ColorId = 3, ModelYear = 2004, DailyPrice = 200, Description = "araç kiralıktır" });
            Console.WriteLine(resultt.Message);
        }
    }
}
