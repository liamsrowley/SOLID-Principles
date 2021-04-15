using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Refactored
{
    class PersonDataCapture
    {
        public static Person Capture()
        {
            // Get user information
            Person output = new Person();

            Console.Write("Please enter your first name: ");
            output.FirstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
