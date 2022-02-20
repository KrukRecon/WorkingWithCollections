using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.ArraysCollections.Demos
{
	class BusRouteRepository
	{
		public static SortedDictionary<int, BusRoute> InitializeRoutes()
		{
            BusRoute route40 = new(40, new string[] { "Morecambe", "Lancaster", "Garstang", "Preston" });
			BusRoute route42 = new(42, new string[] { "Lancaster", "Garstang", "Blackpool" });
			BusRoute route5 = new(5, new string[] { "Overton", "Morecambe", "Carnforth" });
			BusRoute route555 = new(555, new string[] { "Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick" });
			BusRoute route100 = new(100, new string[] { "University", "Lancaster", "Morecambe" });

            var routes = new SortedDictionary<int, BusRoute>
            {
                { 40, route40 },
                { 42, route42 },
                { 5, route5 },
                { 555, route555 },
                { 100, route100 }
            };
            return routes;
		}
	}

}
