using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Refactored
{
    class AccountGenerator
    {
        public static string CreateAccount(Person person)
        {
            return person.FirstName.Substring(0, 1) + person.LastName;
        }
    }
}
