using System;

public class Program
{
    public static void Main()
    {
        try
        {
            double x1 = 1.0, y1 = 2.0;
            double x2 = 1.0, y2 = 2.0;
            double distance = CalculateDistance(x1, y1, x2, y2);
            Console.WriteLine($"Відстань між точками P1({x1}, {y1}) і P2({x2}, {y2}): {distance}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        if (x1 == x2 && y1 == y2)
        {
            throw new ArgumentException("Точки P1 і P2 є однаковими.");
        }

        double deltaX = x1 - x2;
        double deltaY = y1 - y2;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
}
