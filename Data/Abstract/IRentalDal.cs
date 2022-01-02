using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Abstract
{
    public interface IRentalDal:IEntityRepo<Rental>
    {
        List<RentalCarDetailDto> GetRentalCarDetails();
        Rental GetById(int id);
    }
}
