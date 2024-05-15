// Business/Concrete/ColorManager.cs
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        private readonly IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(c => c.Id == id);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }

        public void Delete(int id)
        {
            var color = _colorDal.Get(c => c.Id == id);
            _colorDal.Delete(color);
        }
    }
}
