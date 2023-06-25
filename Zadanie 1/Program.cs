using System;

public class FormatowanieCzasu
{
    public static void Main()
    {
        Console.Title = "Zadanie 1";

        Console.WriteLine("Funkcja wyrażająca czas podany w sekundach, który upłynął od godz. 00:00:00 w formacie HH:MM:SS ");
        Console.WriteLine();

        int calkowiteSekundy = 670;
        string sformatowanyCzas = FormatujCzas(calkowiteSekundy);
        Console.WriteLine(sformatowanyCzas);

        Console.ReadLine();
    }
    public static string FormatujCzas(int calkowiteSekundy)
    {
        int godziny = calkowiteSekundy / 3600;
        int minuty = (calkowiteSekundy % 3600) / 60;
        int sekundy = calkowiteSekundy % 60;

        return $"Sformatowana godzina: {godziny:00}:{minuty:00}:{sekundy:00}";
    }
}