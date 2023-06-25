using System;

public class Program
{
    public static void Main()
    {
        Console.Title = "Zadanie 2";

        Console.WriteLine("Funkcja obliczająca długość odcinka w dwuwymiarowym układzie kartezjańskim");
        Console.WriteLine();

        double x1 = 1.5;
        double y1 = 2.0;
        double x2 = 4.5;
        double y2 = 6.0;

        double dlugoscOdcinka = LiczDlugosc(x1, y1, x2, y2);

        Console.WriteLine("Długość odcinka wynosi: " + dlugoscOdcinka);

        Console.ReadLine();
    }

    public static double LiczDlugosc(double x1, double y1, double x2, double y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        double dlugosc = Math.Sqrt(dx * dx + dy * dy);

        return dlugosc;
    }
}