using Businesss.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Businesss.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car entity)
        {
            if (entity.DailyPrice>=0&&entity.Description.Length>=2)
            {
                _carDal.Add(entity);
            }
            else
            {
                Console.WriteLine("Arabanın fiyatı 0 dan küçük ve açıklaması minimum 2 harften oluşmalı");
            }
            
        }

        public void Delete(Car entity)
        {
            _carDal.Delete(entity);
        }

        public List<Car> GetAll()
        {
           return  _carDal.GetAll();
        }

        public List<Car> GetCarsByColorId(int colorid)
        {
            return _carDal.GetAll(x => x.ColorId == colorid);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(x => x.BrandId == brandId);
        }

        public void Update(Car entity)
        {
            _carDal.Update(entity);

        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            return _carDal.GetById(filter);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetail(Expression<Func<CarDetailDto, bool>> filter=null)
        {
            return _carDal.GetCarDetail(filter);
        }
    }
}
