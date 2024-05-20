using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Flipping_bits
{
    class Result
    {

        /*
         * Complete the 'flippingBits' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts LONG_INTEGER n as parameter.
         */

        public static long flippingBits(long n)
        {
            long result = 0;
            string binary = Convert.ToString(n, 2).PadLeft(32, '0');
            string resultBinary = "";
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0') resultBinary += '1';
                else resultBinary += '0';
            }
            result = Convert.ToInt64(resultBinary, 2);
            return result;
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
                long n = Convert.ToInt64(Console.ReadLine().Trim());

                long result = Result.flippingBits(n);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
