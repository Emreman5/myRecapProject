using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Businesss.Abstract
{
    public interface ICarService:IDalRepo<Car>
    {
        
        List<Car> GetCarsByBrandId(int brandId);
        Car Get(Expression<Func<Car,bool>> filter);
        List<Car> GetCarsByColorId(int colorid);
        List<CarDetailDto> GetCarDetail(Expression<Func<CarDetailDto, bool>> filter=null);
    }

}

