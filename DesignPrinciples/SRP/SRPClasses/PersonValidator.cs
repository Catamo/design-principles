using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.SRP.SRPClasses
{
    public class PersonValidator
    {
        //Method does not need to know in which state is the application
        //We could loop again and ask the user their data once more
        //Validate will not cause the application to end
        public static bool Validate(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.DisplayValidationError("first name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayValidationError("last name");
                return false;
            }

            return true;
        }
    }
}
