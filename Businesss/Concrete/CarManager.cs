using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Results;
using Entities.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car entity)
        {
            if (entity.DailyPrice>=0&&entity.Description.Length>=2)
            {
                _carDal.Add(entity);
                return new SucccessResult(Messages.CarAdded);
            }
            else
            {
                return new ErrorResult();
            }
            
        }

        public IResult Delete(Car entity)
        {
            _carDal.Delete(entity);
            return new SucccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorid)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(x=>x.ColorId==colorid),Messages.CarListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(x => x.BrandId == brandId),Messages.CarListed);
        }

        public IResult Update(Car entity)
        {
            _carDal.Update(entity);
            return new SucccessResult(Messages.CarUpdated);

        }

        public IDataResult<Car> GetById(Expression<Func<Car, bool>> filter)
        {
            return new SuccessDataResult<Car>(_carDal.GetById(filter));
        }

        

        public IDataResult<List<CarDetailDto>> GetCarDetail(Expression<Func<CarDetailDto, bool>> filter=null)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetail(filter),Messages.CarListed);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.GetById(x => x.Id == id));
        }
    }
}
