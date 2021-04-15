using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Refactored
{
    class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application!");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You cannot give an empty {fieldName}");
        }
    }
}
