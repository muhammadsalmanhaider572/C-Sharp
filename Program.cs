using System;

namespace MYApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 40;
            if (number > 0 && number <= 20)
            {
                Console.WriteLine("Good Morning");
            }
            else if (number > 20 && number <= 35) {
                Console.WriteLine("Good Afternoon");
            }
            else 
            { Console.WriteLine("Good Evening");
            }
        }
    } }