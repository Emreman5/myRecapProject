using Business.Concrete;
using Data.Concrete.EntityFramwrok;
using Entities.Concrete;
using System;
using Data.Concrete.EntityFramework;
using Data.Concrete.EntityFramewrok;

namespace ConsoleUI
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var carManager = new CarManager(new EfCarDal());
            var colorManager = new ColorManager(new EfColorDal());
            var brandManager = new BrandManager(new EfBrandDal());
            var customerManager = new CustomerManager(new EFCustomerDal());
            var rentalManager = new RentalManager(new EfRentalDal());
            var rental = new Rental()
            {
                CarId = 1,
                CustomerId = 2,
                Id = 2,
                RentDate = new DateTime(2021, 11, 22),
                ReturnDate = new DateTime(2021, 11, 30)
            };
            var result =rentalManager.Add(rental);
            Console.WriteLine(result.IsSuccess);
         


        }
      


    }
}
