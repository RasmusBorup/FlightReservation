using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flight_Reservation.DataLayer;


namespace Flight_Reservation.Algorith_Rasmus
{
    public class Dijkstras
    {
        private DBRoute dbr;
        private List<Route> routes;//List of all routes in the database

        public Dijkstras()
        {
            dbr = new DBRoute();
            routes = AllRoutes();
        }

        private List<Route> AllRoutes()//Gets all Routes from the database using DBRoute
        {
            return dbr.GetAllRoutes2();
        }

        private List<Route> GetAdjecencies(Airport airport)//Returns all routes going out from a given airport
        {
            List<Route> adjacentRoutes = new List<Route>();
            foreach(Route route in routes.Where(r => r.StartAirport.AirportCode == airport.AirportCode))
            {
                adjacentRoutes.Add(route);
            }
            return adjacentRoutes;
        }

        public List<Route> FindCheapestPath(Airport start, Airport end, int maxLayovers)//Returns the cheapest path from the start airport to the end airport with a maximum amount of layovers
        {
            Console.WriteLine("Running cheapest path algorithm");
            List<SolutionPath> solutionPaths = new List<SolutionPath>();//List of the cheapest path's found to every airport
            solutionPaths.Add(new SolutionPath(start));//Adding the start airport to the solutionPaths list

            List<string> nonViableRoutes = new List<string>();//Paths we can't take because it will make us exceed our maxLayovers. This isn't always true and it will make us block ourselves out from a solution in some specifik cases.
            
            List<string> foundPathsTo = new List<string>();//List of codes from the airports we have allready found the cheapest paths to
            foundPathsTo.Add(start.AirportCode);

            int index = 0;
            while(!foundPathsTo.Contains(end.AirportCode) && index < 100)//The algorithm runs until either the cheapest path to the destination is found or until it has looped some amount of time.
            {//Index < 100 is pretty poor coding but we have had a hard time finding something to prevent an eternal loop
                List<SolutionPath> possibleSolutions = new List<SolutionPath>();//List of possible paths to take extending every known solution. PossiblePaths might be a better name
                SolutionPath solutionPath = new SolutionPath();
                foreach(SolutionPath sPath in solutionPaths)//Finds all the current possible solutions originating from solutionPaths, not ending in a place allready found
                {
                    List<Route> adjecencies = GetAdjecencies(sPath.Destination());
                    foreach (Route adjRoute in adjecencies)
                    {
                        if (!foundPathsTo.Contains(adjRoute.EndAirport.AirportCode) && !nonViableRoutes.Contains(adjRoute.RouteNo.ToString()))
                        {//Checks whether or not a path has allready been found to the endairport of the route or if it is marked as non viable
                            SolutionPath solution = new SolutionPath();
                            foreach (Route route in sPath.GetRoutes())
                            {
                                solution.AddRoute(route);
                            }
                            solution.AddRoute(adjRoute);
                            possibleSolutions.Add(solution);
                        }
                    }
                }
                foreach(SolutionPath possibleSolution in possibleSolutions)//Saves the cheapes route of our possible solutions to solutionPath
                {
                    if (possibleSolution.TotalPrice < solutionPath.TotalPrice || solutionPath.TotalPrice == 0)
                    {
                        solutionPath = possibleSolution;
                    }
                }

                if (solutionPath.GetRoutes().Count < maxLayovers + 2 || (solutionPath.GetRoutes().Count == maxLayovers + 2 && solutionPath.GetRoutes().Last().EndAirport.AirportCode == end.AirportCode))
                {//Continue if the current found solution is not at the max layovers amount or if it is, the last routes destination must be our wanted destination.
                    solutionPaths.Add(solutionPath);//Adds the newly found cheapest path to our list of cheapest paths
                    foundPathsTo.Add(solutionPath.Destination().AirportCode);//Marks the destination of the new solutionPath as found
                }
                else
                {
                    nonViableRoutes.Add(solutionPath.GetRoutes().Last().RouteNo.ToString());//Marks the route so we don't try to use it again
                }
                index++;
            }
            if (index == 100)//If we reach our criteria for preventing the while loop from continuing we clear the routes list from the solution we will return
            {
                //Console.WriteLine("Could not find a route to the destination with only {0} layovers", maxLayovers);
                solutionPaths.Last().ClearRoutes();
            }
            solutionPaths.Last().GetRoutes().RemoveAt(0);
            //foreach (Route route in solutionPaths.Last().GetRoutes())
            //{
            //    Console.WriteLine("Going from {0} to {1}", route.StartAirport.Name, route.EndAirport.Name);
            //}
            return solutionPaths.Last().GetRoutes();
        }
    }
}
