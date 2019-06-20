using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JaegerNetCoreSecond.App_Data.Domain;
using JaegerNetCoreSecond.App_Data.Services;

namespace JaegerNetCoreSecond.App_Data.Controllers
{
    [Route("Driver")]
    public class DriverController : Controller
    {
        private DriverService service;
        public DriverController()
        {
            service = new DriverService();
        }

        [HttpGet, Route("GetDriver", Name = "GetDriver")]
        public Driver GetDriver(int passportCode)
        {
            var result = service.GetDriver(passportCode);
            return result;
        }

        [HttpPost, Route("AddDriver", Name = "AddDriver")]
        public void AddDriver([FromBody] Driver op)
        {
            service.AddDriver(op);
        }

        [HttpGet, Route("UpdateTripStatus", Name = "UpdateTripStatus")]
        public void UpdateTripStatus(int tripId, TripStatus status, int passportCode)
        {
            service.UpdateTripStatus(tripId, status, passportCode);
        }

        [HttpGet, Route("ViewActiveTrip", Name = "ViewActiveTrip")]
        public Trip ViewActiveTrip(int passportCode)
        {
            return service.ViewActiveTrip(passportCode);
        }
    }
}
