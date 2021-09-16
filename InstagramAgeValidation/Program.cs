using System;

namespace InstagramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm arvutab sünniaastaga vanuse
            //kui on vanem kui 13, siis saab instagrami kasutada

            Console.WriteLine("Mis aastal sa sündisid");
            int sünniaasta = Convert.ToInt32(Console.ReadLine());
            int vanus = 2021 - sünniaasta;

            if (vanus < 13)
            {
                Console.WriteLine("Sa ei saa Instagrami kasutada");
            }
            else
            {
                Console.WriteLine("Saad Instagrami kasutada!");

            }
            Console.WriteLine("Kena päeva!");
            Console.ReadLine();
        }
    }
}
