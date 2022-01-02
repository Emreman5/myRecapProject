namespace Core.Utilities.Results
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
