using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Data.Abstract;

namespace Data.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars = new List<Car>();

       

        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            var index = _cars.IndexOf(entity);
            _cars.RemoveAt(index);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Car Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public Car GetById(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public CarDetailDto GetCarDetailById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            var changedCar = _cars.Find(x => x.Id == entity.Id);
            changedCar.BrandId = entity.BrandId;
            changedCar.ColorId = entity.ColorId;
            changedCar.DailyPrice = entity.DailyPrice;
            changedCar.Description = entity.Description;
        }
    }
}
