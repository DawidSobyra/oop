using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Vare
    {
        public string vareNavn { get; set; }
        public int varePris { get; set; }
        public int vareId { get; set; }

        public Vare(string nyVare, int nyPris, int nyVareID)
        {
            vareNavn = nyVare;
            varePris = nyPris;
            vareId = nyVareID;
        }


        public int talRetur(string tekst) 
        {
            try
            {
                int antal = int.Parse(tekst);
                return antal;
            }
            catch (Exception e)
            {
                throw e;
            }           
        }
    }
}
