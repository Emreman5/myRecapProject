using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilties.Results
{
    public class Result : IResult
    {
        public Result(bool isSuccess, string message): this(isSuccess)
        {
           
            this.message = message;
        }
        public Result(bool isSuccess)
        {
            this.isSuccess = isSuccess;
        }

        public bool isSuccess { get; }

        public string message { get; }
    }
}
