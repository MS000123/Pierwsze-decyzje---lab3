// Zad-6
// Zadanie 5. Raport z walki   Napisz program opisujący wynik jednej decyzji podczas walki. Pobierz       aktualne punkty życia bohatera       podstawowe obrażenia broni       informację, czy bohater ma miksturę       wybraną akcję: 1 — atak, 2 — leczenie, 3 — ucieczka   Program powinien działać według reguł       jeśli bohater ma 0 lub mniej punktów życia, wyświetl informację o przegranej i nie wykonuj akcji       dla akcji 1 wyświetl obrażenia       dla akcji 2 wyświetl informację o leczeniu, ale tylko gdy bohater ma miksturę       dla akcji 3 wyświetl informację o ucieczce       dla innej akcji wyświetl „Nieznana akcja.”       jeśli bohater żyje, ale ma mniej niż 20 punktów życia, dodaj ostrzeżenie o niskim zdrowiu   Do wyboru akcji użyj switch-case, a do sprawdzenia stanu bohatera i mikstury użyj instrukcji warunkowych.

// aktualne punkty życia bohatera
int HealthPoints;
Console.WriteLine("Podaj ilość punktów życia bohatera: ");
HealthPoints = int.Parse(Console.ReadLine()!);

// podstawowe obrażenia broni
int BasicWeaponDamage;
Console.WriteLine("Podaj podstawowe obrażenia bronii: ");
BasicWeaponDamage = int.Parse(Console.ReadLine()!);

// informację, czy bohater ma miksturę
bool HavePotion;
Console.WriteLine("Czy bohater posiada miksturę: ");
HavePotion = bool.Parse(Console.ReadLine()!);

// wybraną akcję: 1 — atak, 2 — leczenie, 3 — ucieczka
int ActionType;
Console.WriteLine("Wybierz akcję: \n1 - atak\n2 - leczenie\n3 - ucieczka");
ActionType = int.Parse(Console.ReadLine()!);

// check hp
if (HealthPoints <= 0)
{
    Console.WriteLine("Bohater nie żyje - przegrana");
}
else
{
    // actions type
    switch (ActionType)
    {
        case 1:
            Console.WriteLine($"Bohater atakuje i zadaje {BasicWeaponDamage} punktów obrażeń.");
            break;

        case 2:
            if (HavePotion)
            {
                Console.WriteLine("Bohater używa mikstury i leczy się.");
            }
            else
            {
                Console.WriteLine("Bohater nie ma mikstury i nie może się uleczyć.");
            }
            break;

        case 3:
            Console.WriteLine("Bohater ucieka.");
            break;

        default:
            Console.WriteLine("Nieznana akcja.");
            break;
    }

    if (HealthPoints < 20)
    {
        Console.WriteLine("Ostrzeżenie - niskie HP.");
    }
}


