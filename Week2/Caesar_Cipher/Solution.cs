using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Result
    {

        /*
         * Complete the 'caesarCipher' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. INTEGER k
         */

        public static string caesarCipher(string s, int k)
        {
            string result = "";
            int shift = k % 26;
            foreach (char c in s.ToCharArray())
            {
                int ascii = Convert.ToInt32(c);
                if (ascii >= 65 && ascii <= 90)
                {
                    if (ascii + shift > 90)
                    {
                        ascii = ascii - 26;
                    }
                    result += Convert.ToChar(ascii + shift);
                }
                else if (ascii >= 97 && ascii <= 122)
                {
                    if (ascii + shift > 122)
                    {
                        ascii = ascii - 26;
                    }
                    result += Convert.ToChar(ascii + shift);
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string s = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            string result = Result.caesarCipher(s, k);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
