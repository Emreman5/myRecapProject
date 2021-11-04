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
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color entity)
        {
            _colorDal.Add(entity);
            return new SucccessResult();
        }

        public IResult Delete(Color entity)
        {
            _colorDal.Delete(entity);
            return new SucccessResult();
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetColorById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.GetById(x => x.Id == id));
        }

        public IResult Update(Color entity)
        {
            _colorDal.Update(entity);
            return new SucccessResult();
        }
    }
}
