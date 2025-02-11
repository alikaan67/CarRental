﻿// Entities/DTOs/CarDetailDto.cs
namespace Entities.DTOs
{
    public class CarDetailDto
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
