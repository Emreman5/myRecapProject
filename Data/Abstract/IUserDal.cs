using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Data.Abstract
{
    public interface IUserDal:IEntityRepo<User>
    {
        public List<OperationClaim> GetClaims(User user);
    }
}
