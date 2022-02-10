using System;
using System.Collections.Generic;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Stormtroopers(new List<int>{ 1, 2, 3, 4, 5 }));
            Console.WriteLine(Stormtroopers(new List<int>{ 1, 2, 2, 3, 4, 4, 5 }));
        }

        public static List<int> Stormtroopers(List<int> numbers)
        {
            int dynamicSize = numbers.Count;
           
            for (int i = 0; i < dynamicSize; i++)
            {
                for (int y = i+1; y < dynamicSize; y++)
                {
                   if (numbers[i] == numbers[y])
                    {
                        int del = numbers[y];
                        for (int z = 0; z < dynamicSize; z++)
                        {
                            if (numbers[z] == del)
                            {
                                numbers.RemoveAt(z);
                                dynamicSize = numbers.Count;
                                z = 0;
                            }
                        }
                        i = 0;                       
                    }
                }
            }
            return numbers;
        }



        public static bool playset(string s) 
        {
            int count = 1;
            foreach (char c in s)
            {
                for (int i = count; i < s.Length; i++)
                    if (s[i] == c)
                    {
                        return true;
                    }
                count++;
            }
            return false;
        }
    }
}
