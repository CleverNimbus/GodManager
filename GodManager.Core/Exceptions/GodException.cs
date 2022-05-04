namespace GodManager.Core.Exceptions;
public class GodException : Exception
{
    public GodException(string message) : base(message)
    {

    }

    public GodException(string message, Exception innerEx) : base(message, innerEx)
    {

    }
}