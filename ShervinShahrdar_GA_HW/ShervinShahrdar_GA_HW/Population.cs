using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShervinShahrdar_GA_HW
{
    public class Population
    {
        public List<Route> routes = new List<Route>();
        public int PopulationSize { get { return routes.Count; } }
        public double BestRoute { get { return FittestRoute().distance; } }
        public int RandomRouteID { get { return Helper.rand(routes.Count); } }
        public Population()
        {
            if (!Problem.initialized)
            {
                initializePopulation();
                Problem.initialized = true;
            }
            else
            {
                PutEmpty();
            }

        }

        public Population(int tourSize)
        {
            for (int i = 0; i < tourSize; i++)
            {
                routes.Add(null);
            }
        }

        private void PutEmpty()
        {
            for (int i = 0; i < GeneticAlgorithm.PopulationSize; i++)
            {
                routes.Add(null);
            }
        }


        /// <summary>
        /// Get the individual Route with the optimal route
        /// </summary>
        /// <returns></returns>
        public Route FittestRoute()
        {
            Route fittest = routes.First();
            for (int i = 0; i < routes.Count; i++)
            {
                if (fittest.Fitness <= routes[i].Fitness)
                {
                    fittest = routes[i];
                }
            }
            return fittest;
        }

        /// <summary>
        /// Initialize the Routes (initial 200 population)
        /// </summary>
        private void initializePopulation()
        {
            for (int i = 0; i < GeneticAlgorithm.PopulationSize; i++)
            {
                routes.Add(new Route());
            }
        }

    }
}
