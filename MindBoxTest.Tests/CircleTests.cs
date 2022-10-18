using MindBoxTest.Common.Exceptions;
using MindBoxTest.Common.Figures;
using MindBoxTest.Common.Utility;
using NUnit.Framework;

namespace MindBoxTest.Tests;

public class CircleTests
{
    [Test]
    public void ZeroRadiusTest()
    {
        Assert.Catch<IncorrectCircleRadiusException>(() => new Circle(0d));
    }


    [Test]
    public void NegativeRadiusTest()
    {
        Assert.Catch<IncorrectCircleRadiusException>(() => new Circle(-1d));
    }


    [Test]
    public void LessMinRadiusTest()
    {
        Assert.Catch<IncorrectCircleRadiusException>(() => new Circle(Constants.Accuracy));
    }
		
		
    [Test]
    public void GetSquareTest()
    {
        var radius = 5;
        var circle = new Circle(radius);
        var expectedValue = Math.PI * Math.Pow(radius, 2d); 

        var square = circle.CalculateArea();
			
        Assert.Less(Math.Abs(square-expectedValue), Constants.Accuracy);
    }
}