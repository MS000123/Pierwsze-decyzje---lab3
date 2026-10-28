// Karta Bohatera - Zad 6
// Projekt - Karta bohatera 3.0 

const int MaxHealth = 100;
Console.Write("Podaj imię gracza: ");
String PlayerName = Console.ReadLine()!;
// Health
Console.Write("Podaj liczbę punktów życia: ");
String HealthPoints = Console.ReadLine()!;
int Health = int.Parse(HealthPoints);
// Energy
Console.Write("Podaj ilość energii: ");
String EnergyPoints = Console.ReadLine()!;
int Energy = int.Parse(EnergyPoints);
// Money
Console.Write("Podaj ilość pieniędzy: ");
String MoneyInput = Console.ReadLine()!;
decimal Money = decimal.Parse(MoneyInput);
// Honor
Console.Write("Podaj ilość Honoru: ");
String HonorInput = Console.ReadLine()!;
int Honor = int.Parse(HonorInput);

// Map
Console.Write("Czy bohater ma mapę: ");
bool Map = bool.Parse(Console.ReadLine()!);
// Compass
Console.Write("Czy bohater ma kompas: ");
bool Compass = bool.Parse(Console.ReadLine()!);


// Math

decimal MoneyWithBonus = Money + Honor / 10 * 5;     // 10 honor = + 5 money

double HealthPercent = (double)Health / MaxHealth * 100;    // % of max health
bool Alive = Health > 0;
bool Respected = Honor >= 50;  // 50 honor = respected

bool ReadyForTrip = Alive && Energy >= 20 && (Map || Compass);
string TripInfo = ReadyForTrip ? "TAK" : "NIE";     // true=TAK : false=NIE

decimal Reward = 25;
decimal Cost = 10;
decimal FinalMoney = MoneyWithBonus;
FinalMoney += Reward;      // add reward
FinalMoney -= Cost;        // take cost

int RestHonor = Honor % 10;     // rest of honor after Honor : 10
int HonorToBonus = 10 - RestHonor;      // needed honor for next bonus



// INFO
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Red;  // red col for rdr2
Console.WriteLine("===== RED DEAD REDEMPTION 2 =====");
Console.ResetColor();
Console.WriteLine($"Gracz: {PlayerName}");
Console.WriteLine();

Console.WriteLine("----- STAN BOHATERA -----");
Console.WriteLine($"Zdrowie: {Health}/{MaxHealth} ({HealthPercent:F2}%)");

// alive info
if (!Alive)     // bool false - hero dead
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Bohater nie żyje");
    Console.ResetColor();
}
else if (Health < 25)       // low hp - still alive
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Bohater jest ranny");
    Console.ResetColor();
}
else        // bool true - alive and hp >= 25
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Bohater jest zdrowy");
    Console.ResetColor();
}

Console.WriteLine($"Pieniądze: {Money:F2}");
Console.WriteLine($"Energia: {Energy}");
Console.WriteLine($"Honor: {Honor}");
Console.WriteLine($"Ma mapę: {Map}");
Console.WriteLine($"Ma kompas: {Compass}");
Console.WriteLine($"Żyje: {Alive}");
Console.WriteLine($"Szanowany: {Respected}");
Console.WriteLine($"Gotowy do wyprawy: {TripInfo}");
Console.WriteLine();

Console.WriteLine("----- PO BONUSIE -----");
Console.WriteLine($"Pieniądze: {MoneyWithBonus:F2}");
Console.WriteLine($"Nagroda: {Reward:F2}");
Console.WriteLine($"Koszt: {Cost:F2}");
Console.WriteLine($"Pieniądze na koniec: {FinalMoney:F2}");
Console.WriteLine($"Honor do kolejnego bonusu: {HonorToBonus}");
Console.WriteLine("================================");

// Menu
Console.WriteLine("----- LISTA AKCJI -----");
Console.WriteLine("1 - Sprawdź stan");
Console.WriteLine("2 - Rozpocznij wyprawę");
Console.WriteLine("3 - Przygotuj tonik");
Console.WriteLine("4 - Odpocznij");



// PART 2 - ACTIONS
Console.Write("Wybierz akcję: ");
int ActionChoice = int.Parse(Console.ReadLine()!);

if (!Alive)     // bool false - hero dead
{
    Console.WriteLine("Bohater nie żyje nie może żadnej wykonać akcji.");
}
else
{
    switch (ActionChoice)
    {
        case 1:     // 1 stan
        Console.WriteLine($"Zdrowie: {Health}/{MaxHealth} ({HealthPercent:F2}%)");
        break;

        case 2:     // 2 go for trip (must be rdy)
        if (ReadyForTrip)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bohater rozpoczyna wyprawę.");
            Console.ResetColor();
        }
        else       // not rdy for trip
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Bohater nie jest gotowy do wyprawy.");
            Console.ResetColor();
        }
        break;

        case 3:     // 3 tonic
        Console.WriteLine("Bohater przygotowuje tonik.");
        break;

        case 4:     // 4 rest
        Console.WriteLine("Bohater odpoczywa.");
        break;

        default:     // ??? unkown / wrong input
        Console.WriteLine("Nieznana akcja.");
        break;

    }
}

