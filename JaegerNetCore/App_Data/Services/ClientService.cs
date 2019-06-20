using System;
using System.Collections.Generic;
using JaegerNetCoreSecond.App_Data.Repository;
using JaegerNetCoreSecond.App_Data.Domain;
using System.Threading.Tasks;

namespace JaegerNetCoreSecond.App_Data.Services
{
    public class ClientService
    {
        private ClientRepository repository;
        private TripRepository tripRepository;

        public ClientService()
        {
            repository = new ClientRepository();
            tripRepository = new TripRepository();
        }
        public Client GetClient(int passportCode)
        {
            var result = repository.GetByPassportCode(passportCode) as Client;
            return result;
        }


        public void AddClient(Client client)
        {
            repository.AddUser(client);
        }

        public int CreateTrip(int passportCode, string address)
        {
            var client = GetClient(passportCode);
            var trip = new Trip()
            {
                Client = client,
                Address = address,
                status = TripStatus.Created
            };
            return tripRepository.AddTrip(trip);
        }

        public int AddRate(int passportCode, int tripId, int rate)
        {
            if (tripRepository.GetTrip(tripId).Client.PassportCode != passportCode) throw new Exception("You cant do this!");
            if (tripRepository.GetTrip(tripId).status != TripStatus.Finish) throw new Exception("You cant do this!");
            return tripRepository.AddRateToTrip(tripId, rate);
        }

        public Trip GetTrip(int passportCode, int tripId)
        {
            var trip = tripRepository.GetTrip(tripId);
            if (trip.Client.PassportCode != passportCode) throw new Exception("You cant do this!");
            return trip;
        }
    }
}
