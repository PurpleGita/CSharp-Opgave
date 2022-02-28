using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibary;
using System.IO;
using System.Text.RegularExpressions;

namespace Oprettelse_af_gyldigt_Password
{
    internal class Oprettelse_af_gyldigt_Password
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\rassør\Desktop\Visuel studio opgaver\teks.txt"; //her sætter jeg en path som programmet skal brug til at finde ud af hvor den finde en bestemt fil

            string Brugernavn; //her initiliser jeg nolge strings jeg skal bruge senere
            string Input1; 
            string Input2;
            bool Password_oprettet = false; //her sætter jeg en bool til falsk, fordi programmet skal chekke om den har ændret sig senere i koden.
                                            
            bool Bruger_oprettet = true; //samme som linje 21 men denne her skal starte som true her skaber jeg et nyt objekt som jeg skal bruge senere
            Password_check PC = new Password_check("", "");

            if (!File.Exists(path))//denne if statement chekker om der existere en fil på den path jeg skrev tidligere
            {
                //her er hvad der sker hvis filen ikke eksistere
                Bruger_oprettet = false; //her sætter programmet bruger oprettet til falsk fordi programet skal vide senere at den ikke skal logge ind men oprrette en bruger i stedet.
                Console.WriteLine("ingen bruger fundet opret venligst brugernavn:");
                Brugernavn = Console.ReadLine();
                Password_check ny = new Password_check(Brugernavn, "n"); //skaber et nyt objekt med vædien fra brugeren.
                ny.Oprt_txt();//kalder en metode der opretter en .txt fil og putter tekst ind i den
            }
            while (Bruger_oprettet == true)//denne løkke siger at hvis der allerede er en bruger skal den blive ved med at køre.
            {
                    Console.WriteLine("indstast brugernavn");
                    Input1 = Console.ReadLine();

                    Console.WriteLine("indtast password");
                    Input2 = Console.ReadLine();


                    if (!PC.Check(Input1 , Input2)) //kalder en metode som laver et check baseret på input fra brugeren
                    {
                    Console.Clear();//fjerner tekst fra skærmen så den ikke er så rodet
                    Console.WriteLine("kode eller navn er forkert, prøv igen");//siger til brugen de skal prøve igen inden  loopet starter igen

                }
                    else 
                    {Bruger_oprettet = false; }//hvis inputtet fra brugeren klaret check metoden så stopper loopet

                
            } 
                Console.WriteLine("adgang givet");//lad brugern vide at adgang er givet
                Console.WriteLine("opret nyt password og brugernavn?   J: ja , N: nej");//lad brugen vide at de har et valg
                Input1 = Console.ReadLine();
                if (Input1.ToLower() == "j")//chekker om bruges input er j ligemeget om det stor J eller lille j
                {//hvis det er j så går den vidre ned og spørg brugen om at oprette brugernavn og password.
                Console.WriteLine("opret nyt brugernavn");
                Brugernavn = Console.ReadLine();//siden der ikke er krav omkring brugernavn kan den bare være hvad brugeren skriver
                Console.Clear();//rydder skærmen for tekst
                    while (Password_oprettet == false)//dette loop sikre sig at det næste stykke kode køre indtill password oprettet er true
                    {
                            Console.WriteLine("opret nyt password");
                            string createText = Console.ReadLine();

                            if (PC.Create_Pass(createText, Brugernavn) == true) //her kalder jeg en metode for at se om passwordet brugen har valgt lever op til krævne
                            { 
                             Console.WriteLine("password oprettet");//hvis passwordet lever op til krævne sætte programmet Password_oprettet til sandt og bryder loopet
                             Password_oprettet = true;
                            }
                            else { Console.WriteLine("password møder ikke krav prøv igen" + ""); }//hvis passwordet ikke møder kravne forsætter loopet.
                        }
                    }

                    Console.WriteLine("ses igen");//en farvel besked :D
                    Console.ReadKey();//stopper programmet for at lukke når det er kørt igennem
                }

            }


        }
    
