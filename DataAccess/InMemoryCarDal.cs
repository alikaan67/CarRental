// DataAccess/InMemoryCarDal.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Entities;

namespace DataAccess
{
    public class InMemoryCarDal : IEntityRepository<Car>
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2020, DailyPrice = 100.00m, Description = "Toyota Corolla" },
                new Car { Id = 2, BrandId = 2, ColorId = 2, ModelYear = 2021, DailyPrice = 200.00m, Description = "BMW X3" },
                new Car { Id = 3, BrandId = 3, ColorId = 3, ModelYear = 2022, DailyPrice = 300.00m, Description = "Mercedes-Benz S-Class" }
            };
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            return _cars.SingleOrDefault(filter.Compile());
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return filter == null ? _cars : _cars.Where(filter.Compile()).ToList();
        }

        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Update(Car entity)
        {
            var carToUpdate = _cars.SingleOrDefault(c => c.Id == entity.Id);
            if (carToUpdate != null)
            {
                carToUpdate.BrandId = entity.BrandId;
                carToUpdate.ColorId = entity.ColorId;
                carToUpdate.ModelYear = entity.ModelYear;
                carToUpdate.DailyPrice = entity.DailyPrice;
                carToUpdate.Description = entity.Description;
            }
        }

        public void Delete(Car entity)
        {
            var carToDelete = _cars.SingleOrDefault(c => c.Id == entity.Id);
            if (carToDelete != null)
            {
                _cars.Remove(carToDelete);
            }
        }
    }
}
