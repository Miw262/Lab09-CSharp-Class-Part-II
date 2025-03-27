﻿using System;

class Program
{
    static void Main()
    {
        StaticDemo.i = 123;
        StaticDemo.f = 1234.56f;
        StaticDemo.s = "Hello World!";
        StaticDemo.PrintValues();
    }
}

class StaticDemo
{
    public static int i;
    public static float f;
    public static string s;

    public static void PrintValues()
    {
        Console.WriteLine($"Integer i : {i}, floating point f : {f}, string s  : {s}");
    }
}
