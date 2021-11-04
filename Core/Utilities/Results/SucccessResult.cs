using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilties.Results
{
    public class SucccessResult:Result
    {
        public SucccessResult(string message):base(true,message)
        {

        }
        public SucccessResult():base(true)
        {

        }
    }
}
