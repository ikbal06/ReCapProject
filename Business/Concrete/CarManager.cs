using Business.Abstract;
using Business.Constants;
using Core.Utililies.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==1)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.Listed);
        }

        IDataResult<List<Car>> ICarService.GetCarsByBrandId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(b => b.BrandId == Id));
        }

        IDataResult<List<Car>> ICarService.GetCarsByColorId(int ColorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.ColorId==ColorId));
        }

        IDataResult<Car> ICarService.GetById(int CarId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(ca=>ca.Id==CarId));
        }

        IDataResult<List<CarDetailDto>> ICarService.GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        IResult ICarService.Delete(Car car)
        {
            throw new NotImplementedException();
        }

        IResult ICarService.Update(Car car)
        {
            throw new NotImplementedException();
        }

        public IResult Add(Car car)
        {
            if (car.CarName.Length<2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.Added);
        }
    }
}
