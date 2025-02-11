﻿// Entities/Car.cs
using Core.Entities;

namespace Entities
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string? Description { get; set; }
    }
}
