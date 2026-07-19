using System;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age : ");
            int age = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Age is : " + age);
        }
    }
}