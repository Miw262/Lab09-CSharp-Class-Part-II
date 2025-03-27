using System;

class Program
{
    static void Main()
    {
        // การเข้าถึงสมาชิก static ผ่านชื่อคลาส
        Person.name = "____Person name _____"; // กำหนดค่าให้กับ Person.name
        Console.WriteLine(Person.GetName()); // แสดงผลลัพธ์จาก Person.GetName()

        // การใช้ static member ผ่านชื่อคลาส ไม่ใช่ผ่าน instance
        Student.name = "_______student name_______"; // กำหนดค่าให้กับ Student.name
        Console.WriteLine(Student.GetName()); // แสดงผลลัพธ์จาก Student.GetName()
    }
}

class Person
{
    public static string? name; // ตัวแปร static ของ Person

    public static string GetName()
    {
        return $"Hello from {name}"; // ใช้ชื่อที่เก็บใน name
    }
}

class Student : Person
{
    // Student สืบทอดจาก Person
}
