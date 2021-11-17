using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Utilities;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        
        IDataResult<List<Car>> GetCarsByColorId(int colorid);
        IDataResult<List<CarDetailDto>> GetCarDetail(Expression<Func<CarDetailDto, bool>> filter=null);
        IDataResult<List<Car>> GetAll();

        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IResult DeleteCarById(int id);

       




    }

}

