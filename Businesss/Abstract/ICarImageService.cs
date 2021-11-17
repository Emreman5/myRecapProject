using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        public IResult AddImage(IFormFile file, CarImage image);
        IDataResult<List<CarImage>> GetAll(Expression<Func<CarImage,bool>> filter = null);
        

        IResult Delete(CarImage carImage);
        IResult Update(CarImage carImage, IFormFile file);
        IDataResult<List<CarImage>> ShowImagesByCarId(int id);
    }
}