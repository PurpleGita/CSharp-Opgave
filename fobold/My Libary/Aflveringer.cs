using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace MyLibary
{
    public class Afleveringer //dette er vores class jeg har valgt at kald aflveringer
    {
        private readonly int _pass; //her sætter vi nogle variabler som kun høre til denne class, altså det ændre ikke på vores orginale variabler fra programmet
        private readonly string _mål;
        public Afleveringer(int pass, string mål) //her siger vi så hvad et objekt i denne class skal havde af argumenter
      {
         _pass = pass; //her sætter vi de variabler fra linje 12-13 til at være det samme som vi for fra objektet
         _mål = mål;
      }
    public string Shout() //her skriver vi en metode i vores class, som vi gerne ville bruge til at finde ud af hvad vi skal printe ud
        {
          StringBuilder udskrivning = new StringBuilder("", 50); //her skaber vi så en stringbuilder, som er en form for string vi kan tilføje mere på. 50 er bare at den skal kunne holde op til 50 tegn.


       if (_mål.ToLower() == "mål") //her checkker vi så om brugeren har skrevet mål, ligegyldigt med stort eller småt
         {
                udskrivning.Append("Olé olé olé");//her tilføjer vi så svarnde tekst hvis der mål til vores stringbuilder
          }
           else //else betyder at det næste i koden skal ske hvis den første if statement ikke bliver opfyldt
            {
              if (_pass < 10 & _pass > 1)//denne if statement chekker om der er over 1 aflevering og under 10
                {
                  for (int i = 0; i < _pass; i++) //denne løkke gør koden inden i den flere gange baseret på antal afleveringer
                   {
                        udskrivning.Append("Huh!");//koden her tilføjer Huh! til vores stringbuilder
                   }
                 }
                //her siger vi hvad der skal ske hvis der er over 10 aflevering
                else if (_pass > 10) { udskrivning.Append("High Five - Jubel!!!"); }
                //her siger vi hvad der skal ske hvis der er under 1 aflevering
                else if (_pass < 1) { udskrivning.Append("Shh"); }

            }
          //her skal metoden så retunere hvad end udskrivning nu er blevet sat til, og den skal selvfølige være et string.
          return Convert.ToString(udskrivning);
        }
          
       }
   public class DancerPoints //i dancerpoints classen skriver vi igen hvilke 2 værdier vi skal bruge.
    {
        private readonly int _points; //her sætter vi nogle variabler som kun høre til denne class, altså det ændre ikke på vores orginale variabler fra programmet
        private readonly String _navn;
        public DancerPoints(string navn,int points) //her skriver jeg hvad et objekt i klassen skal havde af værdier
        {
         _points = points; //her sætter vi de variabler fra linje 50-56 til at være det samme som vi for fra objektet
         _navn = navn;
        }

        public string I_alt() //i alt metoden er her for at ligge navn og points sammen så programmet nemmere kan print det
        {

        return (_navn + _points);//hvad i alt skal returnere når vi kalder den
        }

        public static DancerPoints operator+ (DancerPoints a, DancerPoints b)//her bruger jeg en opreator til at sige hvad er sker når 2 dancerpoint objekter plusses sammen

        {
         //den skal lave et nyt objekt som svare til navne og pointsne plusset med hinaden fra objekterne
         DancerPoints c = new DancerPoints(a._navn + "&" + b._navn , a._points + b._points); 
         return(c);//til sidst skal den så retunere det nye objekts værdier.
        
        }

    }

    public class Password_check //her skabes en class
    {

     private string _password; //her sætter vi nogle variabler som kun høre til denne class, altså det ændre ikke på vores orginale variabler fra programmet
     private string _navn;
        public Password_check(string navn, string password)
         {
          _password = password; //her sætter vi de variabler fra linje 12-13 til at være det samme som vi for fra objektet
          _navn = navn;
          }
        public bool Oprt_txt()//en metode som opretter en text baseret på obejktets værdier
        {
        string path = @"C:\Users\rassør\Desktop\Visuel studio opgaver\teks.txt";//sætter path til .txt filen
        File.WriteAllText(path, _navn + Environment.NewLine + _password);
        return true;

        }
        public bool Check(string input1, string input2)//Chckker om password møder requirments
        {

        _password = input2;//input 2 er brugerens input på password
        _navn = input1;//input 1 er brugerens input på brugernavn

        string path = @"C:\Users\rassør\Desktop\Visuel studio opgaver\teks.txt"; //her sætter vi vores path til .txt filen

        string[] readText = File.ReadAllLines(path);//her læser programmet txt filen og gemmer hver linje i en string
        if (_navn == _password) { return false; } //chekker at passwordet ikke er det samme som brugernavn

        if (readText[0] == _navn) //checkker at brugernavn indtastet er det samme som brugernavn gemt i .txt filen
          {
           if (readText[1] == "n") { return (true); } //chekker om passwordet i .txt filen er n, dette er fordi den kun kan blive sat til n hvis der ikke er noget password
           if (readText[1] == _password) //chekker at password indtastet er det samme som password gemt i .txt filen
             {
             return (true);//når Check() bliver returned true betyder det at brugeren har skrevet rigtigt brugernavn og password
              }
              else { return (false); }//hvis brugen ikke har tastet rigtigt bliver Check() returned false
            } else { return (false); }
        }
        public bool Create_Pass(string createText , string Brugernavn)//chekker om det skabte password er oppe til standard
            {
         bool lowercase = false;
         bool uppercase = false;
         string path = @"C:\Users\rassør\Desktop\Visuel studio opgaver\teks.txt";//sætter en path til en .txt fil
         if (createText.Contains("123")) { Console.WriteLine("fejl password må ikke indeholde 123"); return false; }//chekker password ikke har 123 i sig
         if (createText.Length < 12) { Console.WriteLine("fejl password er for kort"); return false; } //chekker om password er for kort
         for (int i = 0; i < createText.Length; i++)//laver en for løkke som køre hver karakter i det nye password igennem
            {
             uppercase = Char.IsUpper(createText, i);
             if (uppercase == true) i = createText.Length + 1;//stopper løkken hvis der er et stort bogstav i
            }

         for (int i = 0; i < createText.Length; i++)//nye løkke
            {
             lowercase = Char.IsLower(createText, i);
             if (lowercase == true) i = createText.Length + 1;//stopper løkken hvis der er et lille bogstav i
             }

         if (lowercase == false) { Console.WriteLine("fejl password skal havde både store og små bogstaver"); return false; }
         if (uppercase == false) { Console.WriteLine("fejl password skal havde både store og små bogstaver"); return false; }
                
         bool isNumber = false;
         bool hasSpechialChars = false;
         Regex rgx = new Regex("[^A-Za-z0-9]");//chekker om der er tal i det nye password
         for (int i = 0; i < createText.Length; i++)
             {
              isNumber = int.TryParse(createText[i].ToString(), out int n);
              if (isNumber == true) i = createText.Length + 1;
              }
         for (int i = 0; i < createText.Length; i++)//chekker om der er spechiale tegn i det nye password
             {
             hasSpechialChars = rgx.IsMatch(createText[i].ToString());
             if (hasSpechialChars == true) i = createText.Length + 1;
             }

             if (isNumber == false) { Console.WriteLine("fejl password skal indeholde tal"); return false; } 
             if (hasSpechialChars == false) { Console.WriteLine("fejl password skal indeholde spechial tegn"); return false; }

             isNumber = int.TryParse(createText[0].ToString(), out int a);//chekker om første tegn er et tal
             if (isNumber == true) { Console.WriteLine("fejl første tegn i password må ikke være et tal"); return false; }

             isNumber = int.TryParse(createText[createText.Length - 1].ToString(), out a);//chekker om andet tegn er et tal
             if (isNumber == true) { Console.WriteLine("fejl sidste tegn i password må ikke være et tal"); return false; }

             bool spaces = createText.Contains(" ");//chekker der mellemrum

             if (spaces == true) { Console.WriteLine("fejl password må ikke indeholde mellemrum, baka"); return false; }

             if (createText.ToLower() == Brugernavn) { Console.WriteLine("fejl password må ikke være det samme som brugernavn dumpap"); return false; } //chekker passwordet ikke er det samme som brugernavn

             if (createText == _password) { Console.WriteLine("fejl password må ikke være det samme som tidligere password"); return false; }; //chekker at password ikke er det samme som tidligere password

           File.WriteAllText(path, Brugernavn + Environment.NewLine + createText);//udsktiver det nye password og brugernavn til .txt filen

         return true;
            
        }
    }


}


