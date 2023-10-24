using System;
namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv sidolängden på triangeln");
            int side = int.Parse(Console.ReadLine()); //vad sidlängden är

            for (int i = 0; i < side; i++) //Hur många rader
            {

                for (int j = 0; j <= i; j++) //hur många gånger * ska skrivas ut per rad
                {
                    Console.Write("*");
                }

                if (i != side - 1) //ny rad efter varje rad, förutom efter den sista raden
                {
                    Console.WriteLine();
                }
            }
        }
    }
}