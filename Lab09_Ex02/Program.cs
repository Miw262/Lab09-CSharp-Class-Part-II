using System;

class Program
{
    static void Main()
    {
        Person.name = "John Doe"; // กำหนดค่าให้กับตัวแปร name ในคลาส Person
        Console.WriteLine(Person.GetName()); // แสดงผลลัพธ์จากฟังก์ชัน GetName
    }
}

static class Person
{
    public static string? name;

    public static string GetName()
    {
        return $"Hello from {name}";
    }
}
