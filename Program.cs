using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Escape_room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            main();
        }

        static void main()
        {
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("kies een kamer 1-5");
                Console.WriteLine("1= keuken");
                Console.WriteLine("2= Slaapkamer");
                Console.WriteLine("3= Kelder");
                Console.WriteLine("4= Coms");
                Console.WriteLine("5= Escape");
                Console.WriteLine("----------------------------------------");
                string inputkamer = Console.ReadLine();


                switch
                    (inputkamer)
                {
                    case "1":
                        EnterKitchen();
                        break;
                    case "2":
                        EnterBedroom();
                        break;
                    case "3":
                        EnterBasement();
                        break;
                    case "4":
                        EnterComs();
                        break;
                    case "5":
                        CheckEscape();
                        break;
                    default:
                        Console.WriteLine("Foute keuze kies 1 tot 5.");
                        break;
                }
            }
        }
        static void EnterKitchen()
        {
            bool correct = false; // Houdt bij of het antwoord goed is

            while (!correct) // Blijf vragen tot correct == true
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Je zoekt een sleutel waar wil je zoeken?");
                Console.WriteLine("1= kluis");
                Console.WriteLine("2= in de kastdeurtjes");
                Console.WriteLine("3= achter het schilderij");
                Console.WriteLine("4= bank");
                Console.WriteLine("----------------------------------------");
                string inputkitchen = Console.ReadLine();


                switch (inputkitchen)
                {
                    case "1":
                        Console.WriteLine("Fout! kijk ergens anders!");
                        break;
                    case "2":
                        Console.WriteLine("Fout! kijk ergens anders!");
                        break;
                    case "3":
                        Console.WriteLine("Fout! kijk ergens anders!");
                        break;
                    case "4":
                        Console.WriteLine("Goed! Je wordt teruggestuurd naar de main hal");
                        Thread.Sleep(2000);
                        main();
                        break;
                    default:
                        Console.WriteLine("Foute keuze kies 1 tot 4.");
                        break;
                }
            }
        }
        static void EnterBedroom()
        {
            bool correct = false; // Houdt bij of het antwoord goed is
            bool code = false;
            bool code2 = false;
            while (!correct) // Blijf vragen tot correct == true
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Je zoekt cijfers waar wil je zoeken?");
                Console.WriteLine("1= in de envelop op tafel");
                Console.WriteLine("2= bank");
                Console.WriteLine("3= achter het schilderij");
                Console.WriteLine("4= in de kastdeurtjes");
                Console.WriteLine("----------------------------------------");
                string inputbedroom = Console.ReadLine();

                if (inputbedroom == "1")
                {
                    Console.WriteLine("je hebt nu 2 getallen zoek de andere 2");
                }
                switch
                    (inputbedroom)
                {
                    case "1":
                        Console.WriteLine("Goed je ziet een 3 en 4 staan");
                        code = true;
                        break;
                    case "2":
                        Console.WriteLine("Fout! kijk ergens anders!");
                        break;
                    case "3":
                        Console.WriteLine("Goed je ziet een 6 en 7 staan");
                        code2 = true;
                        break;
                    case "4":
                        Console.WriteLine("Fout! kijk ergens anders!");
                        break;
                    default:
                        Console.WriteLine("Foute keuze kies 1 tot 4.");
                        break;
                }
                if (code && code2)
                {
                    main();
                }

            }
        }
        static void EnterBasement()
        {
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Je komt in een kelder, maar de lichten zijn uit.");
                Thread.Sleep(1000);
                Console.WriteLine("Met je zaklamp kan je iets zien wat begint te lijken op een doolhof.");
                Thread.Sleep(1000);
                Console.WriteLine("Maak een keuze ga links of rechts.");
                Console.WriteLine("----------------------------------------");

                bool endPointReached = false;
                string[] route = { "links", "rechts", "links", "rechts", "links", "rechts", "rechts", "links", "links" };
                int i = 0;
                while (!endPointReached)
                {           
                    string input = Console.ReadLine();
                    if (input.Equals(route[i])) {
                        Thread.Sleep(0500);
                        Console.WriteLine("Correct!, maak een keuze ga links of rechts.");
                        i++;
                        if (i == route.Length)
                        {
                            Console.WriteLine("Goed zo! je hebt het einde gehaald");
                            endPointReached = true;
                            Thread.Sleep(0500);
                            Console.WriteLine("Je wordt nu terug gestuurd naar de main");
                            Thread.Sleep(1500);
                            main();
                        }
                    } else
                    {
                        Console.WriteLine("Fout! Probeer opnieuw");
                    }
                }
            }
        } 
        static void EnterComs()
        {
            bool correct = false; // Houdt bij of het antwoord goed is

            while (!correct) // Blijf vragen tot goed antwoord
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Je ziet een laptop en moet een bestand downloaden?");
                Console.WriteLine("1= Je download de file");
                Console.WriteLine("2= Je gaat terug naar de main hal");
                Console.WriteLine("----------------------------------------");
                string inputbedroom = Console.ReadLine();


                switch
                    (inputbedroom)
                {
                    case "1":
                        download();
                        break;
                    case "2":
                        main();
                        break;
                    default:
                        Console.WriteLine("Foute keuze kies 1 tot 2.");
                        break;
                }
            }
        }
        static void download()
        {
            Console.Clear();

            Console.WriteLine("   ┌───────────────────────────────────────────────┐");
            Console.WriteLine("   │ Downloading [■                              ] │");
            Console.WriteLine("   └───────────────────────────────────────────────┘");
            Thread.Sleep(9000);


            Console.Clear();

            Console.WriteLine("   ┌───────────────────────────────────────────────┐");
            Console.WriteLine("   │ Downloading [■■■■■                          ] │");
            Console.WriteLine("   └───────────────────────────────────────────────┘");
            Thread.Sleep(9000);

            Console.Clear();

            Console.WriteLine("   ┌───────────────────────────────────────────────┐");
            Console.WriteLine("   │ Downloading [■■■■■■■■■■■                    ] │");
            Console.WriteLine("   └───────────────────────────────────────────────┘");
            Thread.Sleep(9000);

            Console.Clear();

            Console.WriteLine("   ┌───────────────────────────────────────────────┐");
            Console.WriteLine("   │ Downloading [■■■■■■■■■■■■■■■■               ] │");
            Console.WriteLine("   └───────────────────────────────────────────────┘");
            Thread.Sleep(9000);


            Console.Clear();

            Console.WriteLine("   ┌───────────────────────────────────────────────┐");
            Console.WriteLine("   │ Downloading [■■■■■■■■■■■■■■■■■■■            ] │");
            Console.WriteLine("   └───────────────────────────────────────────────┘");
            Thread.Sleep(9000);

            Console.Clear();

            Console.WriteLine("   ┌───────────────────────────────────────────────┐");
            Console.WriteLine("   │ Downloading [■■■■■■■■■■■■■■■■■■■■■■■■       ] │");
            Console.WriteLine("   └───────────────────────────────────────────────┘");
            Thread.Sleep(9000);

            Console.Clear();

            Console.WriteLine("   ┌───────────────────────────────────────────────┐");
            Console.WriteLine("   │ Downloading [■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■ ] │");
            Console.WriteLine("   └───────────────────────────────────────────────┘");
            Thread.Sleep(9000);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   ┌───────────────────────────────────────────────┐");
            Console.WriteLine("   │                Download Complete              │");
            Console.WriteLine("   └───────────────────────────────────────────────┘");
            Console.ResetColor();
            Thread.Sleep(2500);
            Console.WriteLine("de file is 1234.zip");
            Console.WriteLine("Goed! Je wordt teruggestuurd naar de main hal");
            Thread.Sleep(2000);
            main();
        }
        static void CheckEscape()
        {
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Vul bij elke vraag het goede antwoord in die je bij de vorige kamer heb gevonden en ontsnap!");
                Console.WriteLine("----------------------------------------");

                if (!AskQuestion("Waar lag de sleutel in de keuken?", "de bank"))
                {
                    Console.WriteLine("FOUT!.... Je wordt teruggegooid naar de hal");
                    Thread.Sleep(0500);
                    main();
                    return;
                }
                else
                {
                    if (!LastQuestion("In de slaapkamer heb je 4 cijfers gekregen combineer deze voor code en ontsnap! (tip: de volgorde van beide 2 cijfers kloppen al dus combineer ze goed)", "3467"))
                    {
                        Console.WriteLine("FOUT!.... Je wordt teruggegooid naar de hal");
                        Thread.Sleep(0500);
                        main();
                    }
                    else
                    {
                        if (!AskQuestion("Wat was de volgorde van de goede antwoorden in de kelder? (gebruik alleen 'l' of 'r') en schrijf het aan elkaar ", "lrlrlrrll"))
                        {
                            Console.WriteLine("FOUT!.... Je wordt teruggegooid naar de hal");
                            Thread.Sleep(0500);
                            main();
                        }
                        else
                        {
                            if (!AskQuestion("Wat was de naam van de zip file", "1234.zip"))
                            {
                                Console.WriteLine("FOUT!.... Je wordt teruggegooid naar de hal");
                                Thread.Sleep(0500);
                                main();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Gefiliciteerd! je bent ontsnapt!");
                            }
                        }
                    }
                }
            }
        }
        static bool AskQuestion(string vraag, string goede)
        {
            Console.Clear();
            Console.WriteLine(vraag);
            Console.Write("Jouw antwoord: ");
            string antwoord = Console.ReadLine();

            return antwoord.Trim().Equals(goede, StringComparison.OrdinalIgnoreCase);

        }
        static bool LastQuestion(string vraag, string goede)
        {
            Console.Clear();
            Console.WriteLine(vraag);
            Console.Write("De code: ");
            string antwoord = Console.ReadLine();

            return antwoord.Trim().Equals(goede, StringComparison.OrdinalIgnoreCase);

        }
    }
}