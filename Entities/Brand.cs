﻿// Entities/Brand.cs
using Core.Entities;

namespace Entities
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
