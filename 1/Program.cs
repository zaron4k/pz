using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите координату X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        if (x == 0 && y == 0)
        {
            Console.WriteLine("Точка находится в начале координат.");
        }
        else if (x == 0)
        {
            Console.WriteLine("Точка находится на оси Y.");
        }
        else if (y == 0)
        {
            Console.WriteLine("Точка находится на оси X.");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("Точка находится в I координатной четверти.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Точка находится во II координатной четверти.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Точка находится в III координатной четверти.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Точка находится в IV координатной четверти.");
        }
    }
}

