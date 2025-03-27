// เพิ่มคลาส Circle ไว้ในโปรแกรม
class Circle
{
    const double PI = 3.14159;
    public static void PrintCircleArea(double radius)
    {
        System.Console.WriteLine($"Radius = {radius}, Area = {PI * radius * radius}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // เรียกใช้เมธอดของ Circle
        Circle.PrintCircleArea(100);
    }
}
