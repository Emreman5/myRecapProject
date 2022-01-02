using Business.Abstract;
using Core.Utilities;
using Data.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using Core.Utilities.Results;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private readonly IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental entity)
        {
            if (!isAvailable(entity.CarId)) return new ErrorResult();
            _rentalDal.Add(entity);
            return new SucccessResult();
        }

        public IResult Delete(Rental entity)
        {
            _rentalDal.Delete(entity);
            return new SucccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IResult Update(Rental entity)
        {
            _rentalDal.Update(entity);
            return new SucccessResult();
        }
      

        public IDataResult<List<RentalCarDetailDto>> GetRentalCarsDetails()
        {
            return new SuccessDataResult<List<RentalCarDetailDto>>(_rentalDal.GetRentalCarDetails());
        }

        public bool isAvailable(int id)
        {
            var result = DateTime.Compare(_rentalDal.GetById(id).ReturnDate, DateTime.Now);
            return result >= 0;
        }
    }
}
