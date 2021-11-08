using Business.Concrete;
using Businesss.Concrete;
using Data.Concrete.EntityFramwrok;
using Entities.Concrete;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            ColorManager colorManager = new ColorManager(new EFColorDal());
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            CustomerManager customerManager = new CustomerManager(new EFCustomerDal());
            RentalManager rentalManager = new RentalManager(new EFRentalDal());
            Rental rental = new Rental()
            {
                CarId = 1,
                CustomerId = 2,
                Id = 2,
                RentDate = new DateTime(2021, 11, 22),
                ReturnDate = new DateTime(2021, 11, 30)
            };
            var result =rentalManager.Add(rental);
            Console.WriteLine(result.isSuccess);
         


        }
      


    }
}
