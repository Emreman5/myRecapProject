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
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IResult Add(Car entity);
        IResult Delete(Car entity);
        IResult Update(Car entity);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        
        IDataResult<List<Car>> GetCarsByColorId(int colorid);
        IDataResult<List<CarDetailDto>> GetCarDetail(Expression<Func<CarDetailDto, bool>> filter=null);
    }

}

