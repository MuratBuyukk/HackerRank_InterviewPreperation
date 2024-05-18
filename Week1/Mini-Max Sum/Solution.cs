using System.Collections.Generic;
using System.Linq;
using System;

namespace Mini_Max_Sum
{
    class Result
    {

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();
            
            Int64 minSum = 0;
            foreach (var i in arr.Take(4)) minSum += i;

            Int64 maxSum = 0;
            foreach (var i in arr.Skip(1)) maxSum += i;

            Console.WriteLine(minSum + " " + maxSum);
            Console.ReadLine();
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);
        }
    }
}
