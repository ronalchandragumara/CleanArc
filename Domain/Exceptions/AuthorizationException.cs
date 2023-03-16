namespace Domain.Exceptions
{
    public class AuthorizationException : Exception
    {
        public AuthorizationException(string msg) : base(msg)
        {
        }
    }
}
