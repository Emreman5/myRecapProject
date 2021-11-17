using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using Data.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.VisualBasic;

namespace Business.Concrete
{
    public class CarImageManager:ICarImageService
    {
        private ICarImageDal _carImageDal;
        private IFileHelper _fileHelper;
        public CarImageManager(ICarImageDal carImageDal, IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }
        public IDataResult<List<CarImage>> GetAll(Expression<Func<CarImage,bool>> filter = null)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

       


        public IResult AddImage(IFormFile file,CarImage entity)
        {
            var result =BusinessRules.Run(IsImageCapacityExceed(entity));
            if (result!=null)
            {
                return result;
            }
            entity.Date=DateTime.Now;
            entity.Image = _fileHelper.Upload(file, PathConstant.Images);
            _carImageDal.Add(entity);
            return new SucccessResult("Resim kaydedildi");
        }

        public IResult Delete(CarImage entity)
        {
            _fileHelper.Delete(PathConstant.Images+entity.Image);
            _carImageDal.Delete(entity);
            return new SucccessResult();
        }

        public IResult Update(CarImage entity, IFormFile file)
        {
            _fileHelper.Update(file, PathConstant.Images + entity.Image, PathConstant.Images);
            _carImageDal.Update(entity);
            return new SucccessResult();
        }

        public IDataResult<List<CarImage>> ShowImagesByCarId(int id)
        {
            var result = BusinessRules.Run(DoesCarHaveAnImage(id));
            if (result!=null)
            {
                _carImageDal.Add(new CarImage { CarId = id, Date = DateTime.Now, Image = "WebAPI/Businesss/Resources/social-post-default.png" });
            }

            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(x => x.CarId == id));
        }

        public IResult Add(IFormFile file, CarImage image)
        {
            throw new NotImplementedException();
        }

        private IResult IsImageCapacityExceed(CarImage entity)
        {
            var result = _carImageDal.GetAll(i => i.CarId == entity.CarId).Count;
            if (result>=5)
            {
                return new ErrorResult(Messages.ImageCapacity);
            }

            return new SucccessResult(Messages.ImageAdded);
        }

        private IResult DoesCarHaveAnImage(int id)
        {
            var result = _carImageDal.GetAll(x => x.CarId == id).Any();
            if (!result)
            {
                return new SucccessResult();
            }

            return new ErrorResult();
        }
    }
}