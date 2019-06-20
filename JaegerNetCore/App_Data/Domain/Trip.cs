using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaegerNetCoreSecond.App_Data.Domain
{
    public class Trip
    {
        public int Id { get; set; }
        public Client Client { get; set; }

        public String Address { get; set; }

        public Driver Driver { get; set; }

        public Rate Rate { get; set; }

        public TripStatus status { get; set; }
    }
}
