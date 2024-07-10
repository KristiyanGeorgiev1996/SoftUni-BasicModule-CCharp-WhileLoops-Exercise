int badZadachi = int.Parse(Console.ReadLine());
string zadacha = Console.ReadLine();

int numberZadachi = 0;
double ocenkiObshto = 0;
string lastZadacha = string.Empty;
int badOcenki = 0;

while (zadacha != "Enough")
{
    lastZadacha = zadacha;
    double ocenka = int.Parse(Console.ReadLine());
    if (ocenka <= 4)
    {
        badOcenki++;
        if (badOcenki == badZadachi)
        {
            Console.WriteLine($"You need a break, {badOcenki} poor grades.");
            break;
        }
    }
    ocenkiObshto += ocenka;
    numberZadachi++;
   zadacha = Console.ReadLine();
}
if (zadacha == "Enough")
{
    double srednaOcenka = ocenkiObshto / numberZadachi;
    Console.WriteLine($"Average score: {srednaOcenka:f2}");
    Console.WriteLine($"Number of problems: {numberZadachi}");
    Console.WriteLine($"Last problem: {lastZadacha}");
}