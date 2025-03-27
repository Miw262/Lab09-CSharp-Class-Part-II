using System;

class Program
{
    static void Main()
    {
        var a1 = new AAA();
        var a2 = new AAA();

        a1.b1 = 10;
        AAA.b2 = 20; // เข้าถึง static member b2 ผ่านชื่อคลาส
        a2.b1 = 30;
        AAA.b2 = 40; // แก้ไขค่า b2 ผ่านชื่อคลาส

        Console.WriteLine($"a1.b1 = {a1.b1}");
        Console.WriteLine($"AAA.b2 = {AAA.b2}"); // เข้าถึง static member b2 ผ่านชื่อคลาส
        Console.WriteLine($"a2.b1 = {a2.b1}");
        Console.WriteLine($"a2.b2 = {AAA.b2}"); // แสดงค่า b2 ที่มีค่าร่วมกัน
    }
}

class AAA 
{
    public int b1;
    public static int b2; // static field
}
