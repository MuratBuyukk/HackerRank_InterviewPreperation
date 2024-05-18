using System.Collections.Generic;
using System.Linq;
using System;

namespace Plus_Minus
{
    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            int positive = arr.Count(p => p > 0);
            int negative = arr.Count(n => n < 0);
            int zero = arr.Count(z => z == 0);
            int length = arr.Count;

            Console.WriteLine((double)positive / length);
            Console.WriteLine((double)negative / length);
            Console.WriteLine((double)zero / length);
            Console.ReadLine();
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }
}
