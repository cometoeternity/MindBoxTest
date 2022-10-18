namespace MindBoxTest.Common.Utility;

public static class Utility
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
        //or (a, b) = (b, a);
    }
}