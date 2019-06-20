using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using JaegerNetCoreSecond.App_Data.Domain;

namespace JaegerNetCoreSecond.App_Data.Repository
{
    public class OperatorRepository : IUserRepository
    {
        private static List<Operator> operators;


        public OperatorRepository()
        {
            if (operators is null)
                operators = new List<Operator>() {
                    new Operator {
                        Name = "TestOperator",
                        PassportCode = 0,
                        Sex = "female"
                    }
                };
        }


        public User GetByPassportCode(int passportCode)
        {
            return operators.Where(x => x.PassportCode == passportCode).First();
        }

        public void AddUser(User user)
        {
            operators.Add(user as Operator);
        }


        public void DeleteByPassportCode(int passportCode)
        {
        }

    }
}