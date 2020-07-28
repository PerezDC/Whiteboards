using System;

namespace TimeFunction
{
    public class Program
    {
        public static int TimeBetween(int hr1, int min1, int hr2, int min2)
        {
            int timeDiff = 0;
            int ttl1 = hr1 * 60 + min1;
            int ttl2 = hr2 * 60 + min2;
            timeDiff = Math.Abs(ttl2 - ttl1);
            return timeDiff;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("TimeFunction.Program.Main()");
        }
    }
}
