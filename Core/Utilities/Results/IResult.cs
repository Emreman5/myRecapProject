using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilties.Results
{
    public interface IResult
    {
        bool isSuccess { get; }
        string message { get; }

    }
}
