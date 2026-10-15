// Zad-2
// Pobierz od użytkownika jedno słowo opisujące kierunek: północ, południe, wschód albo zachód.   Za pomocą switch-case wyświetl odpowiedni opis       północ — „Wyruszasz w stronę gór.       południe — „Wyruszasz w stronę pustyni.       wschód — „Wyruszasz w stronę lasu.       zachód — „Wyruszasz w stronę morza.   Dla innej wartości wyświetl „Nieznany kierunek.” Pamiętaj o break i default.

Console.WriteLine("Podaj kierunek świata:");
string Direction = Console.ReadLine()!;

switch (Direction)
{
   case "północ":
   Console.WriteLine("Wyruszasz w stronę gór.");
   break;

   case "południe":
   Console.WriteLine("Wyruszasz w stronę pustyni.");
   break;

   case "wschód":
   Console.WriteLine("Wyruszasz w stronę lasu.");
   break;

   case "zachód":
   Console.WriteLine("Wyruszasz w stronę morza.");
   break;

   default:  // wrong
   Console.WriteLine("Błędny kierunek.");
   break;
}
