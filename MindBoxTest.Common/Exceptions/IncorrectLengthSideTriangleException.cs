namespace MindBoxTest.Common.Exceptions;

public class IncorrectLengthSideTriangleException : MindBoxTestException
{
    
    public IncorrectLengthSideTriangleException() : base("Сторона треугольника не может быть такой длины!")
    {
    }
}