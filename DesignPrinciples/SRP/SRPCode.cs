using DesignPrinciples.SRP.SRPClasses;
using System;

namespace DesignPrinciples.SRP
{
    class SRPCode
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.CreateAccount(user);
            StandardMessages.EndApplication();
        }
    }
}
