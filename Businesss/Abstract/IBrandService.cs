using Core.Utilities;
using Core.Utilties.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Businesss.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IResult Add(Brand entity);
        IResult Delete(Brand entity);
        IResult Update(Brand entity);

    }
}

