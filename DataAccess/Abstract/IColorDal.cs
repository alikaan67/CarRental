// DataAccess/Abstract/IColorDal.cs
using Core.DataAccess;
using Entities;

namespace DataAccess.Abstract
{
    public interface IColorDal : IEntityRepository<Color>
    {
    }
}
