using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt PIN-koodi,
            //programm võrdleb sisestatud PIN-koodi arvuga 1234,
            //Kui sisestatud PIN-kood on 1234
            //programm kuvab "Tere tulemast!"
            //kui PIN-kood on vale siis programm kuvab konsooli "Vale PIN, proovi uuesti!"

            Console.WriteLine("Sisestage PIN-kood:");
            int PIN = Convert.ToInt32(Console.ReadLine());
            
            /*if (PIN == 1234)
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale PIN, proovi uuesti!");
            }*/
            if (PIN != 1234){
                Console.WriteLine("Vale PIN, proovi uuesti!");

            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
            
        } 
    }
}
