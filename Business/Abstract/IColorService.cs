// Business/Abstract/IColorService.cs
using System.Collections.Generic;
using Entities;

namespace Business.Abstract
{
    public interface IColorService
    {
        Color GetById(int id);
        List<Color> GetAll();
        void Add(Color color);
        void Update(Color color);
        void Delete(int id);
    }
}
