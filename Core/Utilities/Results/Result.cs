namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool isSuccess, string message): this(isSuccess)
        {
           
            this.Message = message;
        }
        public Result(bool isSuccess)
        {
            this.IsSuccess = isSuccess;
        }

        public bool IsSuccess { get; }

        public string Message { get; }
    }
}
