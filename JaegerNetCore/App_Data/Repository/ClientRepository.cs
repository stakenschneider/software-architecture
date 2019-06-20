using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using JaegerNetCoreSecond.App_Data.Domain;

namespace JaegerNetCoreSecond.App_Data.Repository
{
    public class ClientRepository : IUserRepository
    {
        private static List<Client> clients;

        public ClientRepository()
        {
            if (clients is null)
                clients = new List<Client>() {
                    new Client {
                        Name = "TestClient",
                        PassportCode = 0,
                        Phone = 1
                    }
                };
        }
        
        public User GetByPassportCode(int passportCode)
        {
            return clients.Where(x => x.PassportCode == passportCode).First();
        }

        public void AddUser(User user)
        {
            clients.Add(user as Client);
        }


        public void DeleteByPassportCode(int passportCode)
        {
        }

    }
}
