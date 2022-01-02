using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Data.Abstract;
using Data.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

namespace Data.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepo<Rental, CarProjectContext>, IRentalDal
    {
        public Rental GetById(int id)
        {
            using (CarProjectContext context = new CarProjectContext())
            {
                return context.Rentals.SingleOrDefault(x => x.CarId == id);
            }
        }

        public List<RentalCarDetailDto> GetRentalCarDetails()                   
        {
            using (CarProjectContext context = new CarProjectContext())
            {
                var result = from rental in context.Rentals
                    join customer in context.Customers
                        on rental.CustomerId equals customer.Id
                    join car in context.Cars
                        on rental.CarId equals car.Id
                    join brand in context.Brands
                        on car.BrandId equals brand.Id
                    join user in context.Users
                        on customer.Id equals user.Id
                    join image in context.CarImages
                        on car.Id equals image.CarId
                    select new RentalCarDetailDto
                    {
                        BrandName = brand.Name,
                        CarId = car.Id,
                        CarName = car.CarName,
                        CustomerFirstName = user.FirstName,
                        CustomerId = customer.Id,
                        CustomerLastName = user.LastName,
                        RentDay = rental.RentDate,
                        ReturnDate = rental.ReturnDate,
                        ImagePath = image.Image
                    };
                return result.ToList();
            }
        }
    }
}