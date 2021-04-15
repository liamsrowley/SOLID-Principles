using System;

namespace SRP
{
    /*  Single Responsibility Principle
     * 
     *  SRP states that a given class should have one responsibility - one reason to change.
     *  The below code example shows a class that violates SRP in a number of ways.
     *  At the bottom of this file you will find a comment explaining the multiple responsibilities this class has. Try and identify the reasons yourself first.
     *  You can see the fully refactored code in the 'SRP Refactored' solution.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my application!");

            // Get user information
            Person person = new Person();

            Console.Write("Please enter your first name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            person.LastName = Console.ReadLine();

            // Validate user input
            if (string.IsNullOrEmpty(person.FirstName))
            {
                Console.WriteLine("Your first name cannot be empty");
                Console.ReadLine();
                return;
            }

            if (string.IsNullOrEmpty(person.LastName))
            {
                Console.WriteLine("Your last name cannot be empty");
                Console.ReadLine();
                return;
            }

            // Generate user ID
            Console.WriteLine($"Your unique user ID is {person.FirstName.Substring(0, 1)}{person.LastName}");
            Console.ReadLine();
        }
    }

    /*  This class has multiple responsibilities, meaning it has multiple reasons to change. We need to modify this class for any of the following reasons:
     *  
     *      Changing how the app displays messaging to the user
     *      Changing how we create a new Person and capture their info
     *      Changing how we validate a Person
     *      Changing how we generate a user ID
     *      
     *  For each of those reasons we should ideally have a new class to handle the responsibility. Note that you have to make a call on how granular you want to go with this.
     *  Technically, a welcome message and goodbye message could be their own classes, but this seems a bit too much. It makes more sense to have a StandardMessages class that groups these together.
     *  So the reason to change is if we want to modify the standard messaging utilised throughout the application.
     *  
     *  
     *  Following SRP allows us to create classes that are easier to understand, easier to maintain and easier to reuse.
     *  Note that we are not using the remaining SOLID principles here.
     *  There is more that could be done with this code if we follow SOLID to its full conclusion, but we are only focusing on SRP.
     */
}
