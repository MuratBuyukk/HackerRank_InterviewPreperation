﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipping_The_Matrix
{
    class Result
    {

        /*
         * Complete the 'flippingMatrix' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY matrix as parameter.
         */

        public static int flippingMatrix(List<List<int>> matrix)
        {
            int n = matrix[0].Count;
            int sum = 0;
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    sum += Math.Max(
                        Math.Max(matrix[i][j], matrix[i][n - j - 1]),
                        Math.Max(matrix[n - i - 1][j], matrix[n - i - 1][n - j - 1]));
                }
            }
            return sum;
        }

    }
    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<List<int>> matrix = new List<List<int>>();

                for (int i = 0; i < 2 * n; i++)
                {
                    matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
                }

                int result = Result.flippingMatrix(matrix);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
