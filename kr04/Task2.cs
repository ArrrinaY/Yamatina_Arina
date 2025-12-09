using System;

class Task2
{
    static void Main()
    {
        var small = new object();

        Console.WriteLine($"Маленький объект: поколение {GC.GetGeneration(small)}");

        var large = new byte[100000];

        Console.WriteLine($"Большой объект: поколение {GC.GetGeneration(large)}");

        var obj = new object();
        Console.WriteLine($"\nОбъект до сборки мусора: поколение {GC.GetGeneration(obj)}");

        GC.Collect();

        Console.WriteLine($"\nОбъект после сборки мусора: поколение {GC.GetGeneration(obj)}");

    }
}