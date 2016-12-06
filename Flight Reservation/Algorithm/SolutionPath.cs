using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Flight_Reservation.DataLayer;

namespace Flight_Reservation.Algorith_Rasmus
{
    public class SolutionPath
    {
        private List<Route> routes;
        public double TotalPrice { get; private set; }
        private DBRoute dbr;

        public SolutionPath()
        {
            routes = new List<Route>();
            TotalPrice = 0;
        }

        //The starting point of the algorithm is a solution that has a route whoose endairport = startingpoint
        public SolutionPath(Airport startingPoint)
        {
            routes = new List<Route>();
            dbr = new DBRoute();
            Route route = new Route();
            route.EndAirport = startingPoint;
            route.Price = 0;
            routes.Add(route);
            TotalPrice = 0;
        }

        public void AddRoute(Route route)
        {
            this.routes.Add(route);
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            foreach(Route route in routes)
            {
                TotalPrice += route.Price;
            }
        }

        public List<Route> GetRoutes()
        {
            return routes;
        }

        public Airport Destination()
        {
            Airport airport = new Airport();
            if (routes.Count != 0)
            {
                airport = routes.Last().EndAirport;
            }

            return airport;

        }

        public void ClearRoutes()
        {
            routes = new List<Route>();
        }
    }
}
