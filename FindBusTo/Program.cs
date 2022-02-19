using System;
using System.Collections.Generic;

namespace Pluralsight.ArraysCollections.Demos
{
	class Program
	{
		static void Main(string[] args)
		{
			BusRoute[] allRoutes = BusRouteRepository.InitializeRoutes();

			Console.WriteLine("Where do you want to go to?");
			string location = Console.ReadLine();

			BusRoute[] routes = FindBusTo(allRoutes, location);

			if (routes.Length > 0)
				foreach (var route in routes)
                {
					Console.WriteLine($"You can use route {route}");
				}
			else
				Console.WriteLine($"No routes go to {location}");
		}

		public static BusRoute[] FindBusTo(BusRoute[] routes, string location)
		{
			return Array.FindAll(routes, route => route.Serves(location));
			//foreach (BusRoute route in routes)
			//{
			//	if (route.Origin == location || route.Destination == location)
			//		return route;
			//}
			//return null;
		}
	}
}
