using JaegerNetCoreSecond.App_Data.Domain;
using System.Threading.Tasks;

namespace JaegerNetCoreSecond.App_Data.Repository
{
    public interface IUserRepository
    {
        User GetByPassportCode(int passportCode);

        void AddUser(User user);

        void DeleteByPassportCode(int passportCode);


    }
}
