using JaegerNetCoreSecond.App_Data.Repository;
using JaegerNetCoreSecond.App_Data.Domain;
using System;
using System.Collections.Generic;


namespace JaegerNetCoreSecond.App_Data.Services
{
    public class DriverService
    {
        private DriverRepository repository;
        private TripRepository tripRepository;

        public DriverService()
        {
            repository = new DriverRepository();
            tripRepository = new TripRepository();
        }
        public Driver GetDriver(int passportCode)
        {
            var result = repository.GetByPassportCode(passportCode) as Driver;
            return result;
        }


        public void AddDriver(Driver op)
        {
            repository.AddUser(op);
        }

        
        public void UpdateTripStatus(int tripId, TripStatus status, int passportCode)
        {
            var trip = tripRepository.GetTrip(tripId);
            if (trip.Driver.PassportCode != passportCode) throw new Exception("You cant do this!");
            trip.status = status;
            tripRepository.UpdateTrip(trip, tripId);
        }

        public Trip ViewActiveTrip (int passportCode)
        {
           var driver = repository.GetByPassportCode(passportCode) as Driver;
           return tripRepository.GetTrip(driver.Trip);
        }


    }
}
