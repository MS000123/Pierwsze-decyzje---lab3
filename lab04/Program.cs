// Zad-4
// Zadanie 4. Czy bohater może wejść do lochu?   Pobierz       punkty życia       informację, czy bohater ma klucz       informację, czy zna hasło   Następnie wyświetl decyzję zgodnie z regułami       Jeśli punkty życia są mniejsze lub równe 0, bohater nie może wejść, ponieważ nie żyje       Jeśli żyje i ma klucz albo zna hasło, może wejść       W przeciwnym przypadku nie może wejść, ponieważ nie ma sposobu otwarcia drzwi   Użyj operatorów porównania, &&, 	  	oraz instrukcji if, else if i else   Przykładowe scenariusze   Punkty życia: 8   Ma klucz: fals   Zna hasło: tru   Bohater może wejść do lochu   Punkty życia:    Ma klucz: tru   Zna hasło: tru   Bohater nie może wejść — nie żyje.


int HealthPoints;
Console.WriteLine("Podaj Ilość punktów życia bohatera: ");
HealthPoints = int.Parse(Console.ReadLine()!);

bool HaveKey;
Console.WriteLine(":Czy bohater posiada klucz: ");
HaveKey = bool.Parse(Console.ReadLine()!);

bool KnowPassword;
Console.WriteLine("Czy bohater zna hasło: ");
KnowPassword = bool.Parse(Console.ReadLine()!);

if (HealthPoints <=0 ) // hp
{
    Console.WriteLine("Bohater nie żyje - nie może wejść.");
}
else if (HaveKey || KnowPassword)  // ma klucz lub zna hasło
{
    Console.WriteLine("Bohater może wejść.");
}
else
{
    Console.WriteLine("Bohater nie może wejść - nie ma jak otworzyć drzwi.");
}
