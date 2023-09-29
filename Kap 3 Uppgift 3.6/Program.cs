using System;
namespace Uppgift3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.WriteLine("Vad heter du (För- och efternamn)?");
            string fullName = Console.ReadLine();

            int spaceIndex = fullName.IndexOf(" ");
            string firstName = fullName[..spaceIndex];
            string surname = fullName[(spaceIndex + 1)..];

            if (firstName.CompareTo(surname) < 0)
            {
                Console.WriteLine($"{firstName} kommer först i bokstavsordning.");
            }
            else if (firstName.CompareTo(surname) > 0)
            {
                Console.WriteLine($"{surname} kommer först i bokstavsordning.");
            }
            else
            {
                Console.WriteLine("Du har samma förnamn som efternamn.");
            }
            Console.ReadKey();
        }
    }
}