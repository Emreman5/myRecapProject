using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();

        IResult Add(Brand entity);
        IResult Delete(Brand entity);
        IResult Update(Brand entity);

    }
}

