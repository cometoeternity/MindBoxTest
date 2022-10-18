namespace MindBoxTest.Common.Exceptions;

public class NonExistentTriangleException : MindBoxTestException
{
    public NonExistentTriangleException() : base("Наибольшая сторона треугольника должна быть меньше суммы других сторон")
    {
    }
}