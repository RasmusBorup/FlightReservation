using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Reservation.DataLayer
{
    public class DBRoute
    {
        private DBConnectionDataContext db;
        private DBAirport dbAirp;

        public DBRoute()
        {
            db = new DBConnectionDataContext();
            dbAirp = new DBAirport();
        }

        public Route GetRoute(int routeNo)
        {
            Route route = new Route();
            //if(db.TblRoutes.SingleOrDefault(r => r.RouteNo == routeNo)!= null)
            var rou = db.TblRoutes.SingleOrDefault(r => r.RouteNo == routeNo);

            route.RouteNo = rou.RouteNo;
            route.StartAirport = dbAirp.GetAirport(rou.StartAirport);
            route.EndAirport = dbAirp.GetAirport(rou.EndAirport);
            route.Price = rou.Price;

            return route;
        }

        //Tror den er nødvendig for algoritmen
        public List<Route> RoutesFrom(string airportCode)//Skal sikres
        {
            List<Route> routes = new List<Route>();
            foreach(TblRoute tblRoute in db.TblRoutes.Where(r => r.StartAirport == airportCode))
            {
                Route route = new Route();
                route.RouteNo = tblRoute.RouteNo;
                route.StartAirport = dbAirp.GetAirport(tblRoute.StartAirport);
                route.EndAirport = dbAirp.GetAirport(tblRoute.EndAirport);
                route.Price = tblRoute.Price;

                routes.Add(route);
            }

            return routes;
        }

        public Route RouteTo(Airport airport)
        {
            Route route = new Route();
            try
            {
                TblRoute tblRoute = db.TblRoutes.First(r => r.EndAirport == airport.AirportCode);
                route.EndAirport = dbAirp.GetAirport(tblRoute.EndAirport);
                route.StartAirport = dbAirp.GetAirport(tblRoute.StartAirport);
                route.RouteNo = tblRoute.RouteNo;
                route.Price = tblRoute.Price;
            }
            catch (InvalidOperationException nullreferenceRoute)
            {
                Console.WriteLine(nullreferenceRoute);
            }
            return route;
        }

        //public List<Route> GetAllRoutes()//Not used because it uses a lot of db queries and its hard to secure fx if a route have been deleted in the db
        //{
        //    Route route = new Route();
        //    List<Route> routes = new List<Route>();
        //    int index = 1;
        //    while (index <= db.TblRoutes.Count())
        //    {
        //        var rou = db.TblRoutes.SingleOrDefault(r => r.RouteNo == index);

        //        route.RouteNo = rou.RouteNo;
        //        route.StartAirport = dbAirp.GetAirport(rou.StartAirport);
        //        route.EndAirport = dbAirp.GetAirport(rou.EndAirport);

        //        routes.Add(route);

        //        index++;
        //    }
        //    return routes;
        //}

        public List<Route> GetAllRoutes2()
        {
            List<Route> routes = new List<Route>();
            foreach(TblRoute tblRoute in db.TblRoutes)
            {
                Route route = new Route();
                route.StartAirport = dbAirp.GetAirport(tblRoute.StartAirport);
                route.EndAirport = dbAirp.GetAirport(tblRoute.EndAirport);
                route.RouteNo = tblRoute.RouteNo;
                route.Price = tblRoute.Price;

                routes.Add(route);
            }
            return routes;
        }
    }
}
