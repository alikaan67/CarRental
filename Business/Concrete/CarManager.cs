// Business/Concrete/CarManager.cs

using DataAccess.Abstract;
using Core.Utilities.Results; // Result sınıflarına erişim için gerekli using
using System.Collections.Generic;
using Entities;
using Business.Abstract;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult("Car successfully added.");
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult("Car successfully updated.");
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult("Car successfully deleted.");
        }

        public IDataResult<List<Car>> GetAll()
        {
            var cars = _carDal.GetAll();
            return new SuccessDataResult<List<Car>>(cars, "Cars retrieved successfully.");
        }

        public IDataResult<Car> GetById(int id)
        {
            var car = _carDal.Get(c => c.Id == id);
            return new SuccessDataResult<Car>(car, "Car retrieved successfully.");
        }
    }
}
