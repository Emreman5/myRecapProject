using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

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

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
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
