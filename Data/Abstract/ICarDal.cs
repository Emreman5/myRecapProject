using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace Data.Abstract
{
    public interface ICarDal:IEntityRepo<Car>
    {
        List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto,bool>> filter);
        CarDetailDto GetCarDetailById(int id);
     
    }
}
