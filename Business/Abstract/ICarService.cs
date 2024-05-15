// Business/Abstract/ICarService.cs
using Entities.Concrete; // Car sınıfına erişim için gerekli using
using Core.Utilities.Results; // Result sınıflarına erişim için gerekli using
using System.Collections.Generic;
using Entities;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
    }
}
