using MindBoxTest.Common.Core;
using MindBoxTest.Common.Exceptions;

namespace MindBoxTest.Common.Figures;

public class Triangle : ITriangle
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }
    public bool IsRightTriangle { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA < Utility.Constants.Accuracy)
        {
            throw new IncorrectLengthSideTriangleException();
        }
        if (sideB < Utility.Constants.Accuracy)
        {
            throw new IncorrectLengthSideTriangleException();
        }
        if (sideC < Utility.Constants.Accuracy)
        {
            throw new IncorrectLengthSideTriangleException();
        }
        double maxEdge = Math.Max(sideA, Math.Max(sideB, sideC));
        double perimeter = sideA + sideB + sideC;
        if ((perimeter - maxEdge) - maxEdge < Utility.Constants.Accuracy)
            throw new NonExistentTriangleException();
        
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;

        IsRightTriangle = IsRightTriangleMethod();
    }
    
    public double CalculateArea()
    {
        double half = (SideA + SideB + SideC) / 2;
        double area = Math.Sqrt(half * (half - SideA) * (half - SideB) * (half - SideC));
        return area;
    }
    private bool IsRightTriangleMethod()
         {
             double maxEdge = SideA;
             double b = SideB;
             double c = SideC;
     
             if (maxEdge < b)
             {
                 Utility.Utility.Swap(ref maxEdge, ref b);
             }
     
             if (maxEdge < c)
             {
                 Utility.Utility.Swap(ref maxEdge, ref c);
             }
     
             return Math.Abs(Math.Pow(maxEdge, 2) - (Math.Pow(b, 2) + Math.Pow(c, 2))) < Utility.Constants.Accuracy;
         }
}