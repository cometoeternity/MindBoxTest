using MindBoxTest.Common.Core;
using MindBoxTest.Common.Exceptions;

namespace MindBoxTest.Common.Figures;

public class Circle : ICircle
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius < Utility.Constants.Accuracy)
        {
            throw new IncorrectCircleRadiusException();
        }
        Radius = radius;
    }
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}