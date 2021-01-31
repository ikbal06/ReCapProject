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
            new Car { Id = 1, BrondId = 4, ColorId = 7, DailyPrice = 150, ModelYear = 2017, Description = "Temiz araba" },
            new Car { Id = 2, BrondId = 5, ColorId = 8, DailyPrice = 200, ModelYear = 2018, Description = "Güzel araba" },
            new Car { Id = 3, BrondId = 6, ColorId = 9, DailyPrice = 250, ModelYear = 2019, Description = "Şık araba" },
            new Car { Id = 4, BrondId = 7, ColorId = 6, DailyPrice = 300, ModelYear = 2020, Description = "Spor araba" },
            new Car { Id = 5, BrondId = 8, ColorId = 5, DailyPrice = 350, ModelYear = 2021, Description = "Son Model araba" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int Id)
        {
            return _cars.SingleOrDefault(c => c.Id == Id);
        }

        public void UpDate(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrondId= car.BrondId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
    