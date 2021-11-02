using Core.DataAccess;
using Data.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Entities.Abstract
{
    public interface ICarDal:IEntityRepo<Car>
    {
        List<CarDetailDto> GetCarDetail(Expression<Func<CarDetailDto,bool>> filter);
    }
}
