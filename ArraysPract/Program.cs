using System;

namespace ArraysPract
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int [] { 4, 6, -8, 7, 5 };
            Array.Sort(num);
            
            int min = num[0];
            int max = num[0];

            {
                for (int i = 0; i < num.Length; i++) ;
                if (num [0] < min)
                {
                    min = num[0];
                }

            }
                

            Console.WriteLine(min);
        }
    }
}
