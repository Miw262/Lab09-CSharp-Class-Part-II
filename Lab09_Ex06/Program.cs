using System;

class StaticDemo
{
    public static int i;
    public static float f;
    public static string s;

    public static void PrintValues()
    {
        Console.WriteLine($"Integer i : {i}, floating point f : {f}, string s  : {s}");
    }

    static void Main(string[] args)
    {
        // กำหนดค่าให้กับ static fields
        i = 123;
        f = 1234.56f;
        s = "Hello World!";

        // เรียกใช้ static method
        PrintValues();
    }
}
