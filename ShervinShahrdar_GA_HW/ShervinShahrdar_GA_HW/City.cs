using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShervinShahrdar_GA_HW
{
    public class City
    {
        public double X { get; set; }
        public double Y { get; set; }

        public City()
        {
            this.X = Helper.RandDouble(1000);
            this.Y = Helper.RandDouble(1000);
        }

        public double distanceTo(City city)
        {
            double x = Math.Abs(this.X - city.X);   //x2 - x1
            double y = Math.Abs(this.Y - city.Y);   //y2- y1
            double distance = Math.Sqrt( (x*x) + (y*y)); // distance formula
            return distance;
        }

        static public bool operator ==(City c1, City c2)
        {
            return c1.X == c2.Y && c1.Y == c2.Y;
        }

        static public bool operator !=(City c1, City c2)
        {
            return c1.X == c2.Y && c1.Y == c2.Y;
        }


    }
}
