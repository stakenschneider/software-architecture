using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JaegerNetCoreSecond.App_Data.Domain;
using JaegerNetCoreSecond.App_Data.Services;

namespace JaegerNetCoreSecond.App_Data.Controllers
{
    [Route("Operator")]
    public class OperatorController : Controller
    {
        private OperatorService service;

        public OperatorController()
        {
            service = new OperatorService();
        }

        [HttpGet, Route("GetOperator", Name = "GetOperator")]
        public Operator GetOperator(int passportCode)
        {
            var result = service.GetOperator(passportCode);
            return result;
        }

        [HttpPost, Route("AddOperator", Name = "AddOperator")]
        public void AddOperator([FromBody] Operator op)
        {
            service.AddOperator(op);
        }

        [HttpGet, Route("ViewWaitedTrips", Name = "ViewWaitedTrips")]
        public List<Trip> ViewWaitedTrips()
        {
            return service.ViewWaitedTrips();
        }

        [HttpGet, Route("LockTrip", Name = "LockTrip")]
        public int LockTrip(int passportCode, int id)
        {
            return service.LockTrip(passportCode, id);
        }
    }
}
