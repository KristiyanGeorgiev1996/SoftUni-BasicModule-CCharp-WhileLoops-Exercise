
string steps;
int allSteps = 0;


while (allSteps < 10000)
{
    steps = Console.ReadLine();//2000
    if (steps == "Going home")
    {
        allSteps += int.Parse(Console.ReadLine());break;
        
    }

    allSteps += int.Parse(steps);
}

if (allSteps >= 10000)
{
    Console.WriteLine($"Goal reached! Good job!");
    Console.WriteLine($"{allSteps - 10000} steps over the goal!");
}
else 
{
    Console.WriteLine($"{10000 - allSteps} more steps to reach goal.");
}
