using System;
using System.Threading;

namespace GarbageCollectorLesson
{
    class Program
    {
        private static long milliseconds = 10000000;
        static void Main(string[] args)
        {
            int number = 5;
            bool isError = false;
            char a = 'a';
            // структуры значимые типы живут в области видимости { } 
            // стек => значимые типы(типы значений) int, long, char != NULL нельзя присвоить NULL

            var user = new User
            {
                Login = "admin",
                Password = "12345"
            };

            for (var i = 0;i < 100000;i++)
            {
                GC.Collect();
                Thread.Sleep(1000);
            }
            Console.ReadKey();
        }
    }
}
