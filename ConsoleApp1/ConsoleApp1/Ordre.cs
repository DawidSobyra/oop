using LilleShop;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    public class Ordre
    {
        public int OrdreNummer { get; set; }
        public int OrdreKundeID   { get; set; }
        public int OrdreVareNr { get; set; }

        //List<OrdreVarer> ordreVarers = new List<OrdreVarer>();

        public bool OrdreBetalt; 


        public Ordre(int ordreNr, int ordreKundenr) 
        {
            OrdreNummer = ordreNr;
            OrdreKundeID = ordreKundenr;
            OrdreBetalt = false;
            //OrdreVareNr = 0;
        }



       
    }
}
