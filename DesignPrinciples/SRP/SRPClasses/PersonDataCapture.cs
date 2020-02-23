using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.SRP.SRPClasses
{
    public class PersonDataCapture
    {
        //This is only to focus on the SRP Principle by itself, so there is room for improvement

        public static Person Capture()
        {
            Person output = new Person();

            Console.WriteLine("What is your first name: ");
            output.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name: ");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
