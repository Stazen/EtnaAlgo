using System;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(playset("abcde"));
            Console.WriteLine(playset("abbcdde"));
            Console.WriteLine(playset("abcdeab"));
        }

        public static bool playset(string s) 
        {
            int count = 1;
            foreach (char c in s)
            {
                char charSelected = c;
                for (int i = count; i < s.Length; i++)
                    if (s[i] == charSelected)
                    {
                        return true;
                    }
                count++;
            }
            return false;
        }
    }
}
