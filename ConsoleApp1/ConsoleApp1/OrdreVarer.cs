using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace LilleShop
{
    class OrdreVarer : Vare
    {
        public int Antal { get; set; }
        public OrdreVarer(string nyVare, int nyPris, int nyVareID) : base(nyVare, nyPris, nyVareID) 
        {
            vareNavn = nyVare;
            varePris = nyPris;
            vareId = nyVareID;
            Antal = 1;
        }

        public void OpdateringAntal(int antal) 
        {
            Antal = antal;
        }

    }
}
