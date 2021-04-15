using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Refactored
{
    class PersonValidator
    {
        public static bool Validate(Person person)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(person.FirstName))
            {
                StandardMessages.DisplayValidationError("First Name");
                isValid = false;
            }

            if (string.IsNullOrEmpty(person.LastName))
            {
                StandardMessages.DisplayValidationError("Last Name");
                isValid = false;
            }

            return isValid;
        }
    }
}
