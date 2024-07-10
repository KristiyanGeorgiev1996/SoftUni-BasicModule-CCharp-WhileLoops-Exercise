string book = Console.ReadLine();
string newbook=Console.ReadLine();
int provereniKnigi = 0;


while (newbook != "No More Books")
{
    if (newbook == book)
    {
        Console.WriteLine($"You checked {provereniKnigi} books and found it.");
        break;
    }
    provereniKnigi++;
    newbook = Console.ReadLine();
}

if (newbook== "No More Books")
{
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {provereniKnigi} books.");

}


