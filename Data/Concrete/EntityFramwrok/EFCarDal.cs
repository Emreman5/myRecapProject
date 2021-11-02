using Core.DataAccess.EntityFramework;
using Entities.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Data.Concrete.EntityFramwrok
{
    public class EFCarDal : EfEntityRepo<Car, CarProjectContexxt>, ICarDal
    {
        public Car Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetail(Expression<Func<CarDetailDto, bool>> filter)
        {
            using (CarProjectContexxt context = new CarProjectContexxt())
            {
                var result = from c in context.Cars
                             join ca in context.Brands
                             on c.BrandId equals ca.Id
                             join col in context.Colors
                             on c.ColorId equals col.Id
                             select new CarDetailDto
                             {
                                 BrandName = ca.Name,
                                 CarId = c.Id,
                                 CarName = c.CarName,
                                 ColorName = col.Name,
                                 DailyPrice = c.DailyPrice
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
