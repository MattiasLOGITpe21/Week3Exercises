using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tähte
            //programm kontrollib kas täht on
            //kaashäälik või täishäälik

            Console.WriteLine("Sisesta 1 täht:");
            char täht = Convert.ToChar(Console.ReadLine().ToLower());

            switch (täht)
            {
                case 'a':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'e':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'o':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'i':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'u':
                    Console.WriteLine("Täishäälik");
                    break;
                default:
                    Console.WriteLine("Kaashäälik");
                    break;

            }
            Console.WriteLine("Kena päeva!");
            Console.ReadLine();
        }
    }
}
