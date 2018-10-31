using System;
/*Implement an algorithm to determine if a string has all unique characters. 
         * What if you cannot use additional data structures?*/
namespace String1
{
    class Program
    {      
        static bool UniqChar(string expr)
        {
            bool[] charSet = new bool[256];
            for (int i = 0; i < expr.Length; i++)
            {
                int val = expr[i];
                if (charSet[val])
                {
                    return false;
                }
                else
                    charSet[val] = true;
            }
            return true;
        }

        static bool isUniqChar(string expr)
        {
            int checker = 0;
            for (int i = 0; i < expr.Length; i++)
            {
                int val = expr[i];
                int sh = (1 << val);
                if ((checker & sh) > 0)
                {
                    return false;
                }
                else
                    checker = checker | sh;
            }
            return true;
        }

        static void Main(string[] args)
        {
            bool result = UniqChar("Hello world");
            if (!result)
                Console.WriteLine("A string contains the same characters.");
            else
                Console.WriteLine("A string has all unique characters");

            result = isUniqChar("abcda");
            if (!result)
                Console.WriteLine("A string contains the same characters.");
            else
                Console.WriteLine("A string has all unique characters");
        }
    }
}
