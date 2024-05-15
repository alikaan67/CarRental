// ConsoleUI/Program.cs
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCarService();
            TestBrandService();
            TestColorService();
        }

        static void TestCarService()
        {
            var carService = new CarManager(new EfCarDal());

            // Add new cars
            carService.Add(new Car { BrandId = 1, ColorId = 1, ModelYear = 2022, DailyPrice = 300, Description = "Toyota Corolla" });
            carService.Add(new Car { BrandId = 2, ColorId = 2, ModelYear = 2021, DailyPrice = 500, Description = "BMW X3" });

            // Get all cars
            var cars = carService.GetAll();
            Console.WriteLine("All Cars:");
            foreach (var car in cars)
            {
                Console.WriteLine($"Id: {car.Id}, BrandId: {car.BrandId}, ColorId: {car.ColorId}, ModelYear: {car.ModelYear}, DailyPrice: {car.DailyPrice}, Description: {car.Description}");
            }

            // Update a car
            var carToUpdate = carService.GetById(1);
            carToUpdate.DailyPrice = 350;
            carService.Update(carToUpdate);

            // Delete a car
            carService.Delete(2);
        }

        static void TestBrandService()
        {
            var brandService = new BrandManager(new EfBrandDal());

            // Add new brands
            brandService.Add(new Brand { Name = "Toyota" });
            brandService.Add(new Brand { Name = "BMW" });

            // Get all brands
            var brands = brandService.GetAll();
            Console.WriteLine("\nAll Brands:");
            foreach (var brand in brands)
            {
                Console.WriteLine($"Id: {brand.Id}, Name: {brand.Name}");
            }

            // Update a brand
            var brandToUpdate = brandService.GetById(1);
            brandToUpdate.Name = "Updated Toyota";
            brandService.Update(brandToUpdate);

            // Delete a brand
            brandService.Delete(2);
        }

        static void TestColorService()
        {
            var colorService = new ColorManager(new EfColorDal());

            // Add new colors
            colorService.Add(new Color { Name = "Red" });
            colorService.Add(new Color { Name = "Blue" });

            // Get all colors
            var colors = colorService.GetAll();
            Console.WriteLine("\nAll Colors:");
            foreach (var color in colors)
            {
                Console.WriteLine($"Id: {color.Id}, Name: {color.Name}");
            }

            // Update a color
            var colorToUpdate = colorService.GetById(1);
            colorToUpdate.Name = "Updated Red";
            colorService.Update(colorToUpdate);

            // Delete a color
            colorService.Delete(2);
        }
    }
}
