using System.Collections.Generic;
using System.Threading.Tasks;
using JaegerNetCoreSecond.App_Data.Domain;
using System.Linq;

namespace JaegerNetCoreSecond.App_Data.Repository
{
    public class TripRepository
    {
        private static List<Trip> trips;

        public TripRepository()
        {
            if (trips is null)
                trips = new List<Trip>();
        }


        public int AddTrip(Trip trip)
        {
            int id = trips.Count;
            trip.Id = id;
            trips.Add(trip);
            return id;
        }

        public List<Trip> ViewWaitedTrips()
        {
            return trips.Where(x => x.Driver is null).ToList();
        }

        public Trip GetTrip(int id)
        {
            return trips[id];
        }

        public void UpdateTrip(Trip trip, int id)
        {
            trips[id] = trip;
        }

        public int AddRateToTrip(int id, int rate)
        {
            var trip = trips[id];
            trip.Rate = new Rate { Value = rate };
            trips[id] = trip;
            return id;
        }
    }
}