using Core.Utilities;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService:IServiceRepository<Color>
    {
       
        IDataResult<Color> GetColorById(int id);

    }
}

