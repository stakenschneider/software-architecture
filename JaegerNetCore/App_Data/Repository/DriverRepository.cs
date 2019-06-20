using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JaegerNetCoreSecond.App_Data.Domain;

namespace JaegerNetCoreSecond.App_Data.Repository
{
    public class DriverRepository : IUserRepository
    {
        private static List<Driver> drivers;

        public DriverRepository()
        {
            if (drivers is null)
                drivers = new List<Driver>() {
                    new Driver {
                        Name = "TestDriver",
                        PassportCode = 0,
                        Car = new Car { Number = 1},
                        Trip = -1
                    }
                };
        }


        public User GetByPassportCode(int passportCode)
        {
            return drivers.Where(x => x.PassportCode == passportCode).First();
        }

        public void AddUser(User user)
        {
            drivers.Add(user as Driver);
        }


        public void UpdateUser(User user, int passportCode)
        {
            drivers[passportCode] = user as Driver;
        }


        public void DeleteByPassportCode(int passportCode)
        {
        }

    }
}