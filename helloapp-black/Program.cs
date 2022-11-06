using System;

namespace helloapp_black
{
    internal class Program
    {
        public static void greetBlack()
        {
            Console.WriteLine("hello black");
        }
        public static void greetWhite()
        {
            Console.WriteLine("hello white");
        }

        public static void Main()
        {
            Console.WriteLine("hello everyone");
            greetBlack();
            greetWhite();
        }
    }
}