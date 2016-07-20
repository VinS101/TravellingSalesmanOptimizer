using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShervinShahrdar_GA_HW
{
    public class GeneticAlgorithm
    {
        public static double mutationRate = 0.025;
        public static int tournamentSize = 5;
        public static bool elitism = true;
        public static int PopulationSize = 1000;
        public static int GenerationsToRun = 50;

        private double initialDistance = 0;
        private double finalDistance = 0;

        public GeneticAlgorithm()
        { 
            Population population = new Population(); //initialize
            initialDistance = population.BestRoute;
            for (int i = 0; i < GenerationsToRun; i++)
            {
                Logger.AddResults(population.BestRoute.ToString());
                Logger.Info(population.BestRoute.ToString());
                population = this.Evolve(population);
            }
            finalDistance = population.BestRoute;
            Logger.Info("All done");
            Logger.Info(string.Format("Initial Distance: {0} miles", initialDistance));
            Logger.Info(string.Format("Initial Distance: {0} miles", finalDistance));
            Logger.Info(string.Format("Optimized: {0} miles", initialDistance - finalDistance));
        }

        /// <summary>
        /// evolve 1 generation
        /// </summary>
        /// <param name="p"></param>
        private Population Evolve(Population p)
        {
            Population newPopulation = new Population();

            int offset = 0;
            if(elitism)
            {
                newPopulation.routes[0] = p.FittestRoute();
                //newPopulation.routes.Add(p.FittestRoute());
                offset++;
            }

            for (int i = offset; i < newPopulation.PopulationSize; i++)
            {
                Route parent1 = Tournament(p);
                Route parent2 = Tournament(p);
                Route child = Crossover(parent1, parent2);
                newPopulation.routes[i] = child;
            }

            for (int i = offset; i < newPopulation.routes.Count; i++)
            {
                Mutate(newPopulation.routes[i]);
            }
            return newPopulation;
        }

        private void Mutate(Route route)
        {
            for (int i = 0; i < route.destinations.Count; i++)
            {
                if (new Random().Next() < mutationRate)
                {
                    int pos2 = route.RandomRouteIndex();
                    City city1 = route.destinations[i];
                    City city2 = route.destinations[pos2];

                    //swap cities for mutation
                    route.destinations[pos2] = city1;
                    route.destinations[i] = city2;
                }
            }
        }

        private Route Crossover(Route parent1, Route parent2)
        {
            Route child = new Route();
            int start = parent1.RandomRouteIndex();
            int end = parent1.RandomRouteIndex();

            for(int i = 0; i < child.destinations.Count; i++)
            {
                if (start < end && i > start && i < end)
                {
                    child.destinations[0] = parent1.destinations[i];
                }
                else if (start > end)
                {
                    if (!(i < start && i > end))
                    {
                        child.destinations[i] = parent1.destinations[i];
                    }
                }
            }

            for (int i = 0; i < parent2.destinations.Count; i++)
            { 
                if(!child.destinations.Contains(parent2.destinations[i])) //is this going to work?
                {
                    child.destinations[i] = parent2.destinations[i];
                    break;
                }
            }
            return child;
        }

        private Route Tournament(Population p)
        {
            Population tournament = new Population(tournamentSize); //5
            for (int i = 0; i < tournamentSize; i++)
            {
                tournament.routes[i] = p.routes[p.RandomRouteID];
            }

            Route surviver = tournament.FittestRoute();
            return surviver;
        }
    }
}
