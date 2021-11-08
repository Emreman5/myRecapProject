using Business.Abstract;
using Core.Utilities;
using Core.Utilties.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Businesss.Abstract
{
    public interface ICarService:IServiceRepository<Car>
    {
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        
        IDataResult<List<Car>> GetCarsByColorId(int colorid);
        IDataResult<List<CarDetailDto>> GetCarDetail(Expression<Func<CarDetailDto, bool>> filter=null);
    }

}

