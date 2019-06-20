using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaegerNetCoreSecond.App_Data.Domain
{
    public class Client : User
    {
        public int Phone { get; set; }
    }
}
