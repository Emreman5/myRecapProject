using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<RentalCarDetailDto>> GetRentalCarsDetails();
        IDataResult<List<Rental>> GetAll();

        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);

    }
}
