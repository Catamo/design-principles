using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.SRP.SRPClasses
{
    public class StandardMessages
    {
        //This is only to focus on the SRP Principle by itself, so there is room for improvement

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application!");
        }

        public static void EndApplication()
        {
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid { fieldName }!");
        }
    }
}
