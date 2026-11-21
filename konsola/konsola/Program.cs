using System;
using System.Collections.Generic;

namespace MainProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] tablica = new int[50];
            FillArray(tablica);
            Console.WriteLine("Wpisz wartosc krota chesz wyszukac");
            int number = int.Parse(Console.ReadLine());
            FindNumber(number, tablica); 
        }

        public static void FillArray(int[] tablica)
        {
            Random random = new Random();

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = random.Next(1, 100);
            }
        }

        public static int FindNumber(int numberToFind, int[] tablica)
        {
            Array.Resize(ref tablica, tablica.Length + 1);

            tablica[tablica.Length - 1] = numberToFind;

            foreach (int i in tablica)
            {
                Console.WriteLine(i);
            }

            for(int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] == numberToFind)
                {
                    if (i == tablica.Length - 1)
                    {
                        Console.WriteLine("Trafiono na wartownika");
                        return i; 
                    }
                    else
                    {
                        Console.WriteLine("Odnaleziono szukana liczbe");
                        return i;
                    }
                }
            }

            Console.WriteLine("Blad w szukaniu");
            return 0;
        }
    };
}