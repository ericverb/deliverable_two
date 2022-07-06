using System;

namespace Deliverable2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.\r\n");
            string input = Console.ReadLine();
            int partySize = int.Parse(input);
    
            if (partySize <= 6 && partySize > 0)
            {
                int coffee = 0;
                int water = 0;
                Console.WriteLine("A table for " + partySize+"! Please follow me and take a seat. Let's get everyone started with some drinks. We've got water or coffee.");
                for (int i = 1; i <= partySize; i++)
                {
                    string strOutput = "@@Alright, person number " + i + ", water or coffee?@";
                    strOutput = strOutput.Replace("@", Environment.NewLine);
                    Console.Write(strOutput);
                    string drink = Console.ReadLine();
                    if (drink == "water")
                    {
                        Console.WriteLine("Water, good choice!");
                        water++;
                    }
                    else if (drink == "coffee")
                    {
                        Console.WriteLine("Coffee, okay!");
                        coffee++;
                    }
                    else
                    {
                        Console.WriteLine("We don't have that. No drink for you!");
                    }
                }
                string strOkay = "@@Okay, so that's " + coffee + " coffees and " + water + " waters. I'll be right back. Feel free to grab your food@@";
                strOkay = strOkay.Replace("@", Environment.NewLine);
                Console.WriteLine(strOkay);

                //Math
                double totalBuffets = partySize * 9.99;
                double totalCoffees = coffee * 2.00;
                double totalBill = totalBuffets + totalCoffees;

                Console.WriteLine("Here's your bill! Total price: $"+totalBill);


            }
            else
            {
                Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day.");
            }

        }
    }
}
