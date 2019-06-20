using JaegerNetCoreSecond.App_Data.Repository;
using JaegerNetCoreSecond.App_Data.Domain;
using System.Collections.Generic;

namespace JaegerNetCoreSecond.App_Data.Services
{
    public class OperatorService
    {
        private OperatorRepository repository;
        private TripRepository tripRepository;
        private DriverRepository driverRepository;

        public OperatorService()
        {
            repository = new OperatorRepository();
            tripRepository = new TripRepository();
            driverRepository = new DriverRepository();
        }
        public Operator GetOperator(int passportCode)
        {
            var result = repository.GetByPassportCode(passportCode) as Operator;
            return result;
        }


        public void AddOperator(Operator op)
        {
            repository.AddUser(op);
        }


        public List<Trip> ViewWaitedTrips()
        {
            return tripRepository.ViewWaitedTrips();
        }


        public int LockTrip(int passportCode, int id)
        {
            var driver = driverRepository.GetByPassportCode(passportCode) as Driver;
            var trip = tripRepository.GetTrip(id);
            trip.Driver = driver;
            driver.Trip = trip.Id;
            tripRepository.UpdateTrip(trip, id);
            driverRepository.UpdateUser(driver, passportCode);
            return id;
        }
        



    }
}
