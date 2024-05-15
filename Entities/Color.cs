// Entities/Color.cs
using Core.Entities;
using System.Security.Principal;

namespace Entities
{
    public class Color : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
