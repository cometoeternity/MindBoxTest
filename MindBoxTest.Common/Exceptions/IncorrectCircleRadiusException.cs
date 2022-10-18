namespace MindBoxTest.Common.Exceptions;

public class IncorrectCircleRadiusException : MindBoxTestException
{
    public IncorrectCircleRadiusException() : base("Некорректны радиус круга!")
    {
    }
}