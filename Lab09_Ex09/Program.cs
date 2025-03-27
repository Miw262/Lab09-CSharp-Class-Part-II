using System;

class Program
{
    static void Main(string[] args)
    {
        // เรียกใช้โค้ดที่ต้องการทำงาน
        Circle.PrintCircleArea(100);
    }
}

class Circle
{
    static double PI = 3.14159;
    
    public static void PrintCircleArea(double radius)
    {
        PI = 3.14159265359; // เปลี่ยนค่า PI
        Console.WriteLine($"Radius = {radius}, Area = {PI * radius * radius}");
    }
}
