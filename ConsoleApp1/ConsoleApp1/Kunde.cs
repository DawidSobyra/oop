using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Kunde
    {
        public int kundeID { get; private set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public int Telefon { get; set; }
        public string Adresse { get; set; }
        public int Postnummer { get; set; }


        //Constructor med parametre nyKunde
        public Kunde(int KundeId, string fornavn, string efternavn, int tlf, string adresse, int postnummer )
        {
            kundeID = KundeId;
            Fornavn = fornavn;
            Efternavn = efternavn;
            Telefon = tlf;
            Adresse = adresse;
            Postnummer = postnummer;
        }


        public void NytID(int nytKundId) 
        {
            if (nytKundId > 0)
            {
                kundeID = nytKundId;
            }        
        }

        public override string ToString()
        {
            return "ID: " + kundeID + "   Name: " + Fornavn;
        }
    }
}
