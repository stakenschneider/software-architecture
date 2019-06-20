using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaegerNetCoreSecond.App_Data.Domain
{
    public class Driver : User
    {
        public Car Car { get; set; }

        public int Trip { get; set; }
    }
}
