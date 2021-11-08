using Business.Abstract;
using Core.Utilities;
using Core.Utilties.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Businesss.Abstract
{
    public interface IColorService:IServiceRepository<Color>
    {
       
        IDataResult<Color> GetColorById(int id);

    }
}

