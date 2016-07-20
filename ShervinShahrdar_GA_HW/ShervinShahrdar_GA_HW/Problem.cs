using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShervinShahrdar_GA_HW
{
    public static class Problem
    {
        public static List<City> cities = new List<City>();
        public static bool initialized = false;

        public static void InitializeCities()
        {
            cities.Clear();
            for (int i = 0; i < 100; i++)
            { 
               cities.Add(new City());
            }
        }
    }
}
