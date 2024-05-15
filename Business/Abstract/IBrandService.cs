// Business/Abstract/IBrandService.cs
using System.Collections.Generic;
using Entities;

namespace Business.Abstract
{
    public interface IBrandService
    {
        Brand GetById(int id);
        List<Brand> GetAll();
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(int id);
    }
}
