using Core.Utilities.Results;

namespace Core.Utilities.Business
{
    public static class BusinessRules
    {
        public static IResult Run(params IResult[] args)
        {
            foreach (var result in args)
            {
                if (!result.IsSuccess)
                {
                    return result;
                }
            }

            return null;
        }
    }
}