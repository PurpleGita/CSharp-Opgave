using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibary;

namespace Fodbold_Fan_Support_igen
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool gennemført = false; //her sætter vi en bool til at være falsk og for programmet til at køre indtill den er sat til sandt
            while(gennemført == false) {
            try
            {
                Console.WriteLine("indtast antal afleveringer");//her skriver vi til brugeren at de skal indtasste aflveringer

                int afle = Convert.ToInt32(Console.ReadLine());//her gemmer vi antallet afleveringer som en int

                Console.WriteLine("indtast mål hvis der var mål");
                string møl = Console.ReadLine(); //her gemmer vi hvad brugeren skriver om mål som en string

                Afleveringer Af = new Afleveringer(afle,møl); //her skaber vi så et objekt med navn Af sin har værdierne fra tidligere

                Console.WriteLine(Af.Shout()); //her bruger vi så det nye objekt til at kalde en metode vi printer resultatet af.
                gennemført = true; //her siger vi så at programmet kan gå vidre fra while løkken
            }
            catch (Exception)//catch er til hvis noget går galt, hvis for eksempel programmet prøver at omdanne bogstaver til int32 format
            { Console.WriteLine("noget gik galt"); }} //her siger bare hvad der skal ske hvis der går noget galt.
            


            Console.ReadKey();//denne readkey sikre os bare at programmet ikke lukker lige efter det blevet færdigt
        }
    }
}
