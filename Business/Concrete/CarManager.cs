using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
       public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
       
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carDal.GetAll(c => c.BrandId == Id);
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _carDal.GetAll(c => c.ColorId == Id);
        } 
        
        public void Add(Car car)
        {
            
            if (car.Description.Length>=2 && car.DailyPrice>0)
            {
               _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Araba ismi için 2 veya daha fazla karekter girin ve günlük fiyat 0 dan yüksek olsun.");
            }
        }
        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araba silindi");
        }
        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Araba güncellendi");
        }
    }
}
