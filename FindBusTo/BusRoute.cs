using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.ArraysCollections.Demos
{
	public class BusRoute
	{
		public int Number { get; }
		public string Origin { get; }
		public string Destination { get; }
        public string[] PlacesServed { get; set; }
        public BusRoute(int number, string[] placesServed)
		{
			this.Number = number;
            this.PlacesServed = placesServed;
			this.Origin = placesServed[0];
			this.Destination = placesServed[^1];
		}
		public override string ToString() => $"{Number}: {Origin} -> {Destination}";
		public bool Serves(string destination)
        {
			return Array.Exists(PlacesServed, place => place == destination);
			//foreach (var place in PlacesServed)
   //         {
			//	if (place == destination)
   //             {
			//		return true;
   //             }
   //         }
			//return false;
        }
	}
}