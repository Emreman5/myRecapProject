using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using Data.Abstract;
using Data.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

namespace Data.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepo<Car, CarProjectContext>, ICarDal
    {
        public void Get(int id)
        {
            //TODO
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter)
        {
            using (CarProjectContext context = new CarProjectContext())
            {
                var result = from c in context.Cars
                             join ca in context.Brands
                             on c.BrandId equals ca.Id
                             join col in context.Colors
                             on c.ColorId equals col.Id
                             join image in context.CarImages
                            on c.Id equals image.CarId
                             select new CarDetailDto
                             {
                                 BrandName = ca.Name,
                                 CarId = c.Id,
                                 CarName = c.CarName,
                                 ColorName = col.Name,
                                 DailyPrice = c.DailyPrice,
                                 Image = image.Image
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        public CarDetailDto GetCarDetailById(int id)
        {
            using (CarProjectContext context = new CarProjectContext())
            {
                var result = from c in context.Cars
                    join ca in context.Brands
                        on c.BrandId equals ca.Id
                    join col in context.Colors
                        on c.ColorId equals col.Id
                    join image in context.CarImages
                        on c.Id equals image.CarId
                    select new CarDetailDto
                    {
                        BrandName = ca.Name,
                        CarId = c.Id,
                        CarName = c.CarName,
                        ColorName = col.Name,
                        DailyPrice = c.DailyPrice,
                        Image = image.Image
                    };
                return result.SingleOrDefault(c => c.CarId == id);
            }
        }

        public void DeleteCarById(int id)
        {
            //TODO
        }
    }
}
