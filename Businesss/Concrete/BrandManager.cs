using Businesss.Abstract;
using Core.Utilities;
using Core.Utilties.Results;
using Data.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Businesss.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand entity)
        {
            _brandDal.Add(entity);
            return new SucccessResult();
        }

        public IResult Delete(Brand entity)
        {
            _brandDal.Delete(entity);
            return new SucccessResult();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IResult Update(Brand entity)
        {
            _brandDal.Update(entity);
            return new SucccessResult();
        }

      
    }
}
