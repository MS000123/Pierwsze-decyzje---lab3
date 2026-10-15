// Zad-1
// Poziom łatwy   Zadanie 1. Czy liczba jest parzysta?   Pobierz od użytkownika liczbę całkowitą. Sprawdź, czy jest parzysta, wykorzystując operator reszty z dzielenia.   Program powinien:       wyświetlić komunikat „Liczba jest parzysta.” albo „Liczba jest nieparzysta.”,       zadziałać dla liczb dodatnich, zera i liczb ujemnych,       wykorzystać instrukcję if oraz operator procentu.   Przykładowe wyniki:   Podaj liczbę: 24   Liczba jest parzysta.   Podaj liczbę: 17   Liczba jest nieparzysta.

int Number;
Console.WriteLine("Podaj liczbę: ");
Number = int.Parse(Console.ReadLine());

if (Number % 2 == 0)    // Czy podzielna przez 2, Czy reszta równa 0
{ 
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Liczba jest parzysta"); 
}
else
{ 
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Liczba jest nieparzysta"); 
}