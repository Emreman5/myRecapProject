using Core.DataAccess.EntityFramework;
using Data.Abstract;
using Data.Concrete.EntityFramework;
using Entities.Concrete;

namespace Data.Concrete.EntityFramework
{
    public class EfCarImageDal: EfEntityRepo<CarImage, CarProjectContext>, ICarImageDal
    {
        
    }
}