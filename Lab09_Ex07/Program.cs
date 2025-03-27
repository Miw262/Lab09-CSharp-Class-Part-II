double r = 100.0;
Circle.PrintCircleArea(r);
Circle.PrintCircleCircumference(r);

class Circle
{
    const double PI = 3.14159;
    const double PI2 = PI * 2.0;

    public static void PrintCircleArea(double radius)
    {
        Console.WriteLine($"Radius = {radius}, Area = {PI * radius * radius}");
    }

    public static void PrintCircleCircumference(double radius)
    {
        Console.WriteLine($"Radius = {radius}, Circumference = {PI2 * radius}");
    }
}
