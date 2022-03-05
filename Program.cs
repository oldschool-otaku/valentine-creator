using System;

namespace blyat
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("From: ");
            string from = Console.ReadLine();
            Console.WriteLine("To: ");
            string to = Console.ReadLine();
            Valentine.Print(from, to);
        }
    }
}