double neededMoney = double.Parse(Console.ReadLine());
double ownMoney = double.Parse(Console.ReadLine());

int daysCounter = 0;
int spendCounter = 0;

while (ownMoney < neededMoney)
{
    string input = Console.ReadLine();
    double money = double.Parse(Console.ReadLine());
    daysCounter++;
    if (input == "spend")
    {
        spendCounter++;
        if (spendCounter == 5)
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(daysCounter); break;
        }
        ownMoney -= money;
        if (ownMoney < 0)
        {
            ownMoney = 0;

        }
    }
    else
    {
        spendCounter = 0;
        ownMoney += money;
    }
}
if (ownMoney >= neededMoney)
{
    Console.WriteLine($"You saved the money for {daysCounter} days.");
}