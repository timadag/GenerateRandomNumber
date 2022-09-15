using System;
using System.Collections.Generic;
using System.Linq;

namespace GenerateRandomNumber
{
    public class NumberGenerator
    {
        public static int[] GenerateRandom(int MinValue, int MaxValue, int count) {
            Random rand = new Random();
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = rand.Next(MinValue, MaxValue + 1);
            }
            return numbers;
        }
      
        public static int[] UniqueGenerateRandom(int MinValue, int MaxValue, int count)
        {
            Random rand = new Random();
            HashSet<int> number = new HashSet<int>();
                while(number.Count != count)
                {
                    number.Add(rand.Next(MinValue, MaxValue+1));
                }
            return number.ToArray();
        } 

    }
}
