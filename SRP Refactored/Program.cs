using System;

namespace SRP_Refactored
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            // Create user
            Person user = PersonDataCapture.Capture();

            // Validate user information
            bool isValidUser = PersonValidator.Validate(user);

            if (isValidUser == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            // Generate user ID
            string userId = AccountGenerator.CreateAccount(user);
            Console.WriteLine($"Your unqiue user ID is {userId}");
            StandardMessages.EndApplication();
        }
    }
}
