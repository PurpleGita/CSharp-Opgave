using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibary;

namespace Danse_Konkurrence
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int points = -100; //jeg starter med at sætte points til -100 da jeg ikke regner med man kan få minus points og jeg skal bruge det senere

            Console.WriteLine("indtast navn");
                string navn = Console.ReadLine(); //her sætter jeg en string til at være det som brugern skriver
                Console.WriteLine("indtast points");
            do //her starter jeg så en do while løkke som forsætter indtill points ikke er -100, dette er så brugeren kan blive ved med at forsøge
            {
                try //denne try catch i loppet er til hvis der går noget galt som at omdanne et bogstav til int format
                {
                    points = Convert.ToInt32(Console.ReadLine()); //her bliver points sat  til det brugern skriver
                }
                catch (Exception) //her siger jeg at hvis det tidligere koode slår fejl så skal det under ske
                { Console.WriteLine("noget gik galt, intast venligst kun tal"); } //skriver til brugen der gik noget galt
            } while (points == -100);//her er hvor jeg difinere hvor længe looped skal køre, og det basicly indtill points er sat.
                
                DancerPoints D1 = new DancerPoints(navn,points);//her laver jeg så et nyt objekt i dancerpoint classen og bruger de værdier fra tidligere

            Console.Clear();//ryder bare skærmen så den ikke bliver for rodet
                points = -100; //sætter points til -100 så vi kan bruge den igen
                Console.WriteLine("indtast navn");
                navn = (Console.ReadLine());
                Console.WriteLine("indtast points"); //her gør jeg så det samme som sidst med points og navn
            do
            {
                try
                {
                    points = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                { Console.WriteLine("noget gik galt, intast venligst kun tal"); }
            } while (points == -100);

                DancerPoints D2 = new DancerPoints( navn,points); //jeg sætter så de nye værdier for points og navn i et andet objekt
                DancerPoints D3 = (D1 + D2); //til sidst plusser programet de 2 objekter sammen til en ny, og udskriver den
                Console.WriteLine(D3.I_alt());

            
            Console.ReadKey();//er her for ikke at lukke programmet når det kørt igennem.
        }
    }

 }
