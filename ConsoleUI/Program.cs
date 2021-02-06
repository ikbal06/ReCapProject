using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Id : " + car.Id + "\nBrand Id : " + car.BrandId +
                    "\nColor Id : " + car.ColorId + "\nModel : " + car.ModelYear + "\nCar Type : " + car.Description +
                    "\nDaily Price : " + car.DailyPrice);
            }
            carManager.Add(new Car
            {
                BrandId = 4,
                ColorId = 4,
                ModelYear = 2020,
                Description = "Hybrid",
                DailyPrice = 0 // Sıfır girildiğinde hata mesajı alındı.Test Başarılı!
            });

            brandManager.Add(new Brand
            {
                BrandId = 5,
                BrandName = "A" //Marka ismi minimum 2 karakter olmalı hata mesajı alındı.Test Başarılı!
            });

            foreach (var Brands in brandManager.GetAll())
            {
                Console.WriteLine(Brands.BrandName);
            }
        }
    }
}
