using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShervinShahrdar_GA_HW
{
    public class Route
    {
        public double Fitness { get; set; }
        public double distance = 0; //miles
        public List<City> destinations = new List<City>();

        public Route()
        {
            GetCopyOfCities();  //Set the initial genome
            Shuffle();
            CalculateTotalDistance();
            CalculateFitness();
        }

        private void CalculateFitness()
        {
            Fitness = 1 / distance;
        }

        public int RandomRouteIndex()
        {
            return Helper.rand(destinations.Count);
        }

        private void CalculateTotalDistance()
        {
            for (int i = 0; i < 100; i++)
            {
                City cityFrom = destinations[i];
                City cityTo;
                if (i + 1 < destinations.Count)
                {
                    cityTo = destinations[i + 1];
                }
                else
                {
                    cityTo = destinations.First(); //end of the destinaiton
                }
                this.distance += Math.Round(cityFrom.distanceTo(cityTo));
            }
        }

        private void Shuffle()
        {
           this.destinations.Shuffle();
           if (!IsItRandom())  //shuffle if not random
           {
               Shuffle();
           }
        }

        private bool IsItRandom()
        {
            int match = 0;
            for (int i = 0; i < destinations.Count; i++)
            {
                if (destinations[i] == Problem.cities[i])
                {
                    match++;
                }
            }
            if (match > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void GetCopyOfCities()
        {
            foreach (City c in Problem.cities)
            {
                this.destinations.Add(c);
            }
        }
    }
}
