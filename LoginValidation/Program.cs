using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //altgr + < == |
            //shift + 6 == &

            //programm küsib kasutajatunnust ja parooli
            //programm kontrollib sisestatud kasutajatunnust ja parooli
            //kui sisestatud tunnus on "admin"
            //ja sisestatud parool on "admin1234"
            //siis programm kuvab "Tere tulemast!"
            //else "Vale kasutajatunnus või parool"

            Console.WriteLine("Sisesta kasutajatunnus:");
            string username = Console.ReadLine();
            Console.WriteLine("Sisesta parool:");
            string password = Console.ReadLine();

            //option 1
            /*if (username == "admin" && password == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus või parool");
            }*/

            //option 2
            if (username != "admin" || password != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või parool");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
            Console.ReadLine();
        }
    }
}
