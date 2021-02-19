using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using Using.Core.Entities;

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
            //GetCarDetailsTest();

            //CustomerManagerGetAllTest();
            //UserManagerAddTest();
            //RentalManagerTest();

        }

        private static void RentalManagerTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var rentalResult = rentalManager.Add(new Rental { CarId = 1, CustomerId = 2, ReturnDate = new DateTime(2021, 02, 12), RentDate = DateTime.Today });
            Console.WriteLine(rentalResult.Message);
        }

        private static void UserManagerAddTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var userResult = userManager.Add(new User { FirstName = "inci", LastName = "şeker", Email = "gısnodfkmlşs@gmail.com", Password = "cgvhk" });
            Console.WriteLine(userResult.Message);
        }

        private static void CustomerManagerGetAllTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var customerResult = customerManager.GetAll();
            if (customerResult.Success)
            {
                foreach (var customer in customerResult.Data)
                {
                    Console.WriteLine(customer.UserId + " " + customer.CompanyName);
                }
            }
            Console.ReadKey();
        }

        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var carResult = carManager.GetCarDetails();
            if (carResult.Success)
            {
                foreach (var car in carResult.Data)
                 {
                    Console.WriteLine(car.CarName);
                 }
            }
            
        }

        private static void CarGetAllTest()
        {
            CarManager carManger = new CarManager(new EfCarDal());
            var carResult = carManger.GetAll();
            foreach (var car in carResult.Data)
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
            colorManager.Delete(new Color { ColorName = "sarı",Id=3});
        }
    }
}
