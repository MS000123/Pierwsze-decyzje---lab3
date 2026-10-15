// Zad-3
// Użyj if, else if i else. Sprawdź szczególnie wartości graniczne: 0, 12, 13, 17, 18, 64 i 65.

int Age;
Console.WriteLine("Podaj wiek: ");
Age = int.Parse(Console.ReadLine()!);

if (Age < 0)
{
    Console.WriteLine("Niepoprawny wiek");
}
else if (Age <= 12 )
{
    Console.WriteLine("Dziecko");
}
else if (Age >= 13 && Age <= 17)
{
    Console.WriteLine("Nastolatek");
}
else if (Age >= 18 && Age <= 64)
{
    Console.WriteLine("osoba dorosła");
}
else if (Age >= 65)
{
    Console.WriteLine("senior");
}

