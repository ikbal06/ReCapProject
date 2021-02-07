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
            //CarGetAllTest();
            //BrandUpdateTest();
            //CarAddTest();
            //colorDeleteTest();

            GetCarDetailsTest();

        }

        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
            }
        }

        private static void CarGetAllTest()
        {
            CarManager carManger = new CarManager(new EfCarDal());
            foreach (var car in carManger.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void BrandUpdateTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Update(new Brand { BrandId = 10, BrandName = "Audi" });
        }

        private static void CarAddTest()
        {
            Car car10 = new Car
            { Id = 7, BrandId = 2, CarName = "araba1", ColorId = 1, DailyPrice = 500, Description = "Yeni araba", ModelYear = 2021 };

            Console.WriteLine(car10.Description + "/" + car10.Id + "/" + car10.ColorId + "/" + car10.CarName + "/" + car10.BrandId + "/" + car10.DailyPrice + "/" + car10.ModelYear);
        }

        private static void colorDeleteTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Delete(new Color { ColorName = "açık gri", Id = 11 });
        }
    }
}
