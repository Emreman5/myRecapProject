using Business.Concrete;
using Data.Concrete.EntityFramwrok;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            ColorManager colorManager = new ColorManager(new EFColorDal());
            Car car2 = new Car()
            {
                Description = "a",
                DailyPrice = 2000,
                ColorId = 3,
                Id = 5,
                BrandId = 5,
                ModelYear = 2018
            };
            carManager.Add(car2);

           
            foreach (var item in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
