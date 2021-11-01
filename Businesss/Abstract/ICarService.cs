using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Businesss.Abstract
{
    public interface ICarService:IDalRepo<Car>
    {
        
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorid);
    }

}

