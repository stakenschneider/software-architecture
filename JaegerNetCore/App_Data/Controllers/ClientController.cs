using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JaegerNetCoreSecond.App_Data.Domain;
using JaegerNetCoreSecond.App_Data.Services;

namespace JaegerNetCoreSecond.App_Data.Controllers
{
    [Route("Client")]
    public class ClientController : Controller
    {
        private ClientService service;
        public ClientController()
        {
            service = new ClientService();
        }

        [HttpGet, Route("GetClient", Name = "GetClient")]
        public Client GetClient(int passportCode)
        {
                var result =  service.GetClient(passportCode);
                return result;
        }

        [HttpPost, Route("AddClient", Name = "AddClient")]
        public void AddClient([FromBody] Client client)
        {
            service.AddClient(client);
        }

        [HttpGet, Route("CreateTrip", Name = "CreateTrip")]
        public int CreateTrip(int passportCode, string address)
        {
           return service.CreateTrip(passportCode, address);
        }

        [HttpGet, Route("AddRate", Name = "AddRate")]
        public int AddRate(int passportCode, int tripid, int rate)
        {
            return service.AddRate(passportCode, tripid, rate);
        }


        [HttpGet, Route("ViewTrip", Name = "ViewTrip")]
        public Trip ViewTrip(int passportCode, int tripid)
        {
            return service.GetTrip(passportCode, tripid);
        }
    }
}
