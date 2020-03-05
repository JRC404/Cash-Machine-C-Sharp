using System;

namespace csharp_cashMachine
{
    class Program
    {
        void withdrawl(int bankBalance, int withdrawlAmount)
        {
            bankBalance -= withdrawlAmount;
            Console.WriteLine("My new balance is: {0}", bankBalance);
        }

        // void checkPin(string userInput, string pinNumber)

        void checkPin()
        {
        START:
            string pinNumber = "1000";
            string userInput;
            Console.Write("Please enter your input: ");
            userInput = Console.ReadLine();
            // Console.WriteLine(userInput);

            if (pinNumber == userInput)
            {
                Console.WriteLine("Woah, you are allowed in.");
            }
            else
            {
                // Console.WriteLine("Go away.");
                goto START;
            }
            // if userInput is equal to the pinNumber... do something
            // if it isn't... do something
        }


        static void Main(string[] args)
        {
            Program cashMachine = new Program();
            cashMachine.withdrawl(500, 30);
            cashMachine.checkPin();
            // taking user input



        }
    }
}

