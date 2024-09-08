namespace BobAndJoeDudes
{
    internal class Program
    {
        static void Main()
        {
            Guy joe = new Guy { Name = "Joe", Cash = 100 };
            Guy bob = new Guy { Name = "Bob", Cash = 50 };

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.Write("Enter an amount: ");
                string? howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int amount))
                {
                    Console.Write("Who should give the cash: ");
                    string? whichGuy = Console.ReadLine();
                    if(whichGuy == "Joe" & joe.Cash != 0 )
                    {
                        int cashGiven = joe.GiveCash(amount);
                        bob.ReceiveCash(cashGiven);
                    }
                    else if (whichGuy == "Bob" & bob.Cash != 0)
                    {
                        int cashGiven = bob.GiveCash(amount);
                        joe.ReceiveCash(cashGiven);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe or 'Bob'.");
                    }

                }
                else
                {
                    Console.WriteLine("Please enter an amount(or blank line to exit).");
                }
            }

        }
    }
}
