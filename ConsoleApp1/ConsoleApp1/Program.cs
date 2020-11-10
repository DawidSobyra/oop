using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{ 
    class Program
    {
        static void DeleteKunde(int SletKunde, List<Kunde> lst)
        {
            Kunde objSlet = lst.Find(x => x.kundeID == SletKunde);
            lst.Remove(objSlet);
        }


        static void Main(string[] args)
        {

            List<Kunde> kunder = new List<Kunde>();
            List<Vare> varer = new List<Vare>();
            List<Ordre> ordrer = new List<Ordre>();


            int kundeID = 1;
            int vareID = 1;
            //int ordreNr = 1;
            int kundeCnt = 0;
            int vareCnt = 0;

            

            
           
            /*
              
            //DEMO KODE:
            Kunde k = new Kunde("Knud",12345678,1);
            Console.WriteLine("Før: ID {0} Navn {1} tlf {2}", k.kundeId, k.kundeNavn, k.kundeTelefon);
            k.kundeNavn = "Palle";
            k.kundeTelefon = 34567812;
            k.NytID(12);
            //k.kundeId = 12;


            Console.WriteLine("Efter: ID {0} Navn {1} tlf {2}", k.kundeId, k.kundeNavn, k.kundeTelefon);
            */

            /////////////////////////////////////////////////////////////
            
            //Indtastet kunder til test
            kunder.Add(new Kunde("Peter Schnelle", 84638322, 1));
            kunder.Add(new Kunde("Pete Schnell", 86750932, 2));
            kunder.Add(new Kunde("Skinny Pete", 59373945, 3));

            //Indtastet varer
            varer.Add(new Vare("Banan", 6, 1));
            varer.Add(new Vare("Æble", 3, 2));
            varer.Add(new Vare("Pære", 2, 3));

            

            /////////////////////////////////////////////////////////////

           int valg;

           do
           {


           Console.WriteLine("1) Opret kunde");
           Console.WriteLine("2) Opret vare");
           Console.WriteLine("3) Opret ordre");
           Console.WriteLine("4) Vis ordre");
           Console.WriteLine("5) Slet kunde");
           Console.WriteLine("6) Slet ordre");
           Console.WriteLine("7) Slet vare");


           valg = int.Parse(Console.ReadLine());

           switch (valg)
           {
               case 1:
                       //Opret kunde



                       Console.WriteLine("Indtast kundens navn");
                       string currFornavnavn = Console.ReadLine();

                       Console.WriteLine("Indtast kundens telefonnummer");
                       int currNyTlf = int.Parse(Console.ReadLine());

                       kunder.Add(new Kunde(currFornavn, currNyTlf, kundeID));

                       Console.WriteLine("Navn: {0}, Telefon: {1}, ID = {2}", kunder[kundeCnt].Fornavn, kunder[kundeCnt].Telefon, kunder[kundeCnt].kundeID);

                       kundeID++;
                       kundeCnt++;



                   break;


                case 2:
                       //Opret vare
                       Console.WriteLine("Indtast varens navn");
                       string currVareNavn = Console.ReadLine();

                       Console.WriteLine("Indtast varens pris");
                       int currVarePris = int.Parse(Console.ReadLine());

                       varer.Add(new Vare(currVareNavn, currVarePris, vareID));

                       Console.WriteLine("Varen hedder {0} og koster {1} kroner stykket", varer[vareCnt].vareNavn, varer[vareCnt].varePris);

                       vareID++;
                       vareCnt++;



                       break;



                 case 3:
                       //Opret ordre

                       Console.Clear();

                       if (kunder.Count > 0)
                       {


                           Console.WriteLine("Hvem skal have en ordre lavet?");
                           Console.WriteLine("Indtast kundens ID");

                            //Husk try-catch eller tilsvarende
                             int currKundeNr = int.Parse(Console.ReadLine());

                            if (kunder.Find(x => x.kundeID == currKundeNr) != null)
                            {
                                Random nr = new Random();
                                int ordreNr = nr.Next(10000, 100000);
                                ordrer.Add(new Ordre(ordreNr, currKundeNr));
                                //Tilføj kode til vare
                                Console.WriteLine(ordreNr);
                                //ordrer[ordrer.Count-1].OrdreVareNr = 1;
                                //ordreID++;
                            }
                            else
                            {
                                Console.WriteLine("Fejl kunden eksisterer ikke");
                            }

                            //Vis liste med varer
                            Console.WriteLine("**********************************************");
                            foreach(var Vare in varer)
                            {
                                Console.WriteLine("{0} Produkt: {1} {2}kr", Vare.vareId, Vare.vareNavn, Vare.varePris);
                            }
                            Console.WriteLine("********************************************");


                            
                            //Hvad vil du købe? - Skriv nr.
                            // Tjek nr. eksistere - tilføj vare ID - spørg om antal

                            // Loop: Vil du købe flere vare? - når der er mulighed for at tilføje flere...
                            /*
                            Console.WriteLine("Hvor mange varer skal kunden købe?");
                            
                            try
                            {
                                int vareAntal = int.Parse(Console.ReadLine());
                                //Vare nyVare = new Vare("",0,0);
                                //int vareAntal = nyVare.talRetur(Console.ReadLine());

                                for (int i = 0; i < vareAntal; i++)
                                {
                                    Console.WriteLine("");
                                    string bestilTing = Console.ReadLine();
                                }

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                //throw;
                            }
                            */
                            //Console.WriteLine("Navn: {0}, Telefon: {1}, ID = {2}", kunder[currKundeNr].kundeNavn, kunder[currKundeNr].kundeTelefon, kunder[currKundeNr].kundeId);
                            //orderKundeID = kunder[currKundeNr].kundeId;

                            //orderVareID = varer[currNr].vareId;

                        }
                       else
                       {
                           Console.WriteLine("Indtast kunder først!");
                       }

                       break;
                 case 4:
                        //Vis ordre

                        Console.WriteLine("*********************************************");
                        foreach (var Ordre in ordrer)
                        {
                            Console.WriteLine("Ordrenummer: {0} Kunde ID: {1} Ordre Varenummer: {2}", Ordre.OrdreNummer, Ordre.OrdreKundeID, Ordre.OrdreVareNr);
                            Console.WriteLine(kunder.Find(x => x.kundeID == Ordre.OrdreKundeID).Fornavn);
                                
                        }
                        Console.WriteLine("*********************************************");

                        break;
                 case 5:
                        //Slet kunde
                        Console.WriteLine("Skriv kunde ID:");
                        int iSletKunde = Convert.ToInt32(Console.ReadLine());
                        DeleteKunde(iSletKunde, kunder);

                        foreach (var kunde in kunder)
                        {
                            Console.WriteLine(kunde.ToString());
                        }
                        break;
                 case 6:
                       //Slet ordre

                       break;
                 case 7:
                       //Slet vare

                       break;
               }
               Console.ReadKey();
               Console.Clear();
           } while (true);
            
        }


    }
}
