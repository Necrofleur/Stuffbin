using System;

namespace MeineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 5;
            Console.WriteLine(AddiereZahlen(a, b).ToString());
            Console.ReadLine();
        }

        public static int AddiereZahlen (int a, int b)
        {
            return a + b;
        }
    }
}
