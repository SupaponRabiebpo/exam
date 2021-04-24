using System;

namespace ข้อ6
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            int wide = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int C = 1;
            while (C <= step)
            {
                for (int j = 1; j <= high; j++)
                {
                    for (int i = 1; i <= C * wide; i++)
                    {
                        Console.Write(letter);
                    }
                    Console.WriteLine("");
                }
                C++;
            }
        }
    }
}
