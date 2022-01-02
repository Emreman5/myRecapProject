using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;


namespace Data.Abstract
{
   public interface ICustomerDal:IEntityRepo<Customer>
    {
        List<CustomerDetailDto> GetCustomersDetails();
    }
}
