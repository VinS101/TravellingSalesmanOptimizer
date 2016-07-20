using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShervinShahrdar_GA_HW
{
    public static class Helper
    {
        static Random random = new Random();
        static double Min = 0;


        public static double RandDouble(double max)
        {
            return random.NextDouble() * (max - Min) + Min;
        }

        public static int rand(int max)
        {
            return random.Next(max);
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
