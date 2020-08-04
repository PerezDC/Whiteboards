using System;
using System.Linq;

namespace CountDistinctElements
{
    public class DistinctElements
    {
        // create a method that reutns the number of distinct elements in an int[]
        // example: { 8, 6, 7, 5, 3, 0, 9, 8, 6, 7, 5, 3, 0, 9 } returns 7

        public static int DistinctElementsCheck(int[] thisArray)
        {
            int counter = 1;
            for (int i = 1; i < thisArray.Length; i++)
            {
                int j = 0;
                for (j = 0; j < i; j++)
                    if (thisArray[i] == thisArray[j])
                        break;

                if (i == j)
                    counter++;
            }
            return counter;
        }

    }
}
