namespace MindBoxTest.Common.Exceptions;

public abstract class MindBoxTestException : Exception
{
    protected MindBoxTestException(string message) : base(message)
    {
    }
}