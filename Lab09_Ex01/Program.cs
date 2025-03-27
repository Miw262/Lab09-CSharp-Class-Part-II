using System;

class Circle
{
    static double PI = 3.14159;

    public static void PrintCircleArea(double radius)
    {
        PI = 3.14159265359; // เปลี่ยนค่า PI

        Console.WriteLine($"Radius = {radius}, Area = {PI * radius * radius}");
    }

    // เพิ่ม Main method สำหรับ entry point
    static void Main(string[] args)
    {
        // ตัวอย่างการใช้ฟังก์ชัน PrintCircleArea
        PrintCircleArea(10);
    }
}
