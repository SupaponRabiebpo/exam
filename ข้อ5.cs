using System;

namespace ข้อ5
{
    class Program
    {
        static void Main(string[] args)
        {
            / ข้อ5

            int day = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            string menu = Console.ReadLine();



            if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5)
            {


                while (menu != "End")
                {
                    int BreakfastSet = 5;
                    int WeekendSet = 2;
                    int Coffee = 3;

                    if (menu == "Breakfast Set" || menu == "Weekend Set" || menu == "Coffee")
                    {
                        if (menu == "Breakfast Set") ;
                        {
                            if (BreakfastSet <= 0)
                            {
                                Console.WriteLine("Sorry your order is out of stock");
                                if (time > 11)
                                {
                                    Console.WriteLine("Sorry your order in not available");
                                }
                                else
                                {
                                    BreakfastSet -= 1;
                                }
                            }
                        }
                        if (menu == "Weekend Set")
                        {
                            if (WeekendSet <= 0)
                            {
                                Console.WriteLine("Sorry your order is not available");
                            }
                            else { WeekendSet -= 1; }
                        }
                        if (menu == "Coffee")
                        {
                            if (Coffee <= 0)
                            {
                                Console.WriteLine("Please enter a void menu");
                            }
                            else { Coffee -= 1; }
                        }
                        if (day == 6 || day == 7)
                        {
                            if (menu == "Breakfast Set")
                            {
                                if (BreakfastSet <= 0)
                                {
                                    Console.WriteLine("Sorry your order is out of stock");
                                }
                                if (time > 11)
                                {
                                    Console.WriteLine("Sorry your order is not available");
                                }
                                else { BreakfastSet -= 1; }
                            }
                        }
                        if (menu == "Coffee")
                        {
                            if (Coffee <= 0)
                            {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                            else { Coffee -= 1; }
                        }
                        if (menu == "Weekend set")
                        {
                            if (WeekendSet <= 0)
                            {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                            else { WeekendSet -= 1; }
                        }
                    }


                }
                Console.WriteLine("Please enter a void menu");

            }
        }
    }
}
