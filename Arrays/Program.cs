using System;

namespace Arrays
{
    class Program
    {

        static void DoStuff()
        {
            Random LotteryDraw = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(LotteryDraw.Next(1, 10));
            }
        }

        static void Main()
        {
            DoStuff();

           // testScores = new int[10];
            int sum;
            sum = 0;
            //int[] testScores;
            //testScores = new int[7] { 72, 80, 99, 100, 75, 62 };
            int[] tests = new int[10];
            int[] testScores = new int[10] { 12, 564, 123, 541, 648, 89, 35, 0, 0, 0 };
            int[] scores = new int[] { 54, 55, 58, 88 };
            int[] results = { 15, 25, 37, 8, 20 };
            var testResults = new int[] { 62, 17, 82, 990, 530 };
            var moreTestResults = new int[5] { 62, 17, 82, 990, 530 };

            string[] Seasons = { "winter", "spring", "summer", "fall" };



            for (int i = 0; i < testScores.Length; i++)
            {
                sum += testScores[i];
                Console.WriteLine($" next is {testScores[i]}; total {sum}");
            }
        }
    }
}
