using System;

namespace AndExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks
            //miinimum matemaatikas 85 punkti;
            //miinimum keemias 90 punkti;
            //miinimum bioloogias 95 punkti;
            //programm palub kasutajal enda eksami punktid sisestada
            //programm otsustab, kas kasutaja saab arstiks õppida

            Console.WriteLine("Matemaatika eksami punktid:");
            int matemaatika = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Keemia eksami punktid:");
            int keemia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bioloogia eksami punktid");
            int bioloogia = Convert.ToInt32(Console.ReadLine());

            if (matemaatika >= 85 && keemia >= 90 && bioloogia >= 95)
            {
                Console.WriteLine("Saad arstiks õppida!");
            }
            else
            {
                Console.WriteLine("Ei saa arstiks õppida");
            }
            Console.ReadLine();
        }
    }
}
