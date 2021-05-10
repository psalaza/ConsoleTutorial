using System;

namespace consoletest
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            x = Console.ReadLine();
            int y = Convert.ToInt32(x);
            y *=y;
            y += 14;
            y -=3;
            Console.WriteLine(y);
           // Console.WriteLine(y*y + 14 -3);

        }
    }
}
