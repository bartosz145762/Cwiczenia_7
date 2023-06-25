using System;

namespace Ćw_7_zajęcia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Zadanie 4";

            Console.WriteLine("Funkcja znajdująca najbardziej podobne wiersze w tablicy");
            Console.WriteLine();

            Console.WriteLine("Wygenerowana tablica:");
            Console.WriteLine();
            int[,] array = new int[5, 4];
            WypelnijLosowo(array);
            WyswietlTablice(array);

            Console.WriteLine();
            znajdzNajbardziejPodobneWiersze(array, out int row1, out int row2);
            Console.WriteLine($"Najbardziej podobne wiersze: {row1 + 1} i {row2 + 1}");

            Console.ReadLine();
        }

        static void WypelnijLosowo(int[,] array)
        {
            Random random = new Random();

            int iloscWierszy = array.GetLength(0);
            int iloscKolumn = array.GetLength(1);

            for (int i = 0; i < iloscWierszy; i++)
            {
                for (int j = 0; j < iloscKolumn; j++)
                {
                    array[i, j] = random.Next(1, 10);
                }
            }
        }

        static void WyswietlTablice(int[,] array)
        {
            int iloscWierszy = array.GetLength(0);
            int iloscKolumn = array.GetLength(1);

            for (int i = 0; i < iloscWierszy; i++)
            {
                for (int j = 0; j < iloscKolumn; j++)
                {
                    Console.Write(" " + array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void znajdzNajbardziejPodobneWiersze(int[,] array, out int row1, out int row2)
        {
            row1 = 0;
            row2 = 0;

            long najmniejszaRoznica = long.MaxValue;

            int iloscWierszy = array.GetLength(0);
            int iloscKolumn = array.GetLength(1);

            for (int i = 0; i < iloscWierszy; i++)
            {
                for (int j = i + 1; j < iloscWierszy; j++)
                {
                    long roznica = wyliczRoznice(array, i, j);
                    if (roznica < najmniejszaRoznica)
                    {
                        najmniejszaRoznica = roznica;
                        row1 = i;
                        row2 = j;
                    }
                }
            }
        }

        static long wyliczRoznice(int[,] array, int i, int j)
        {
            int iloscKolumn = array.GetLength(1);
            long roznica = 0;

            for (int kol = 0; kol < iloscKolumn; kol++)
            {
                roznica += (long)Math.Pow(array[i, kol] - array[j, kol], 2);
            }
            return roznica;
        }
    }
}