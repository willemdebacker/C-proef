using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoWagenpark
{
    public class Personeel
    {
        private Int32 personeels_ID;
        private String voornaam;
        private String achternaam;
        private String telefoonnummer;
        private String email;
        private String adres;
        private String gemeente;
        private String functie;
        private string paswoord;

        public Int32 Personeels_ID
        {
            get { return personeels_ID; }
           
        }

        public String Voornaam
        {
            get { return voornaam; }
            set { voornaam = value; }
        }

        public String Achternaam
        {
            get { return achternaam; }
            set { achternaam = value; }

        }

        public String Telefoonnummer
        {
            get { return telefoonnummer; }
            set { telefoonnummer = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        public String Gemeente
        {
            get { return gemeente; }
            set { gemeente = value; }
        }

        public String Functie
        {
            get { return functie; }
            set { functie = value; }
        }

        public String Paswoord
        {
            get { return paswoord; }
            set { paswoord = value; }
        }

        public Personeel(Int32 nPersoneel_ID, String nVoornaam, String nAchternaam, String nTelefoonnummer, String nEmail, String nAdres, String nGemeente,  String nFunctie, String nPaswoord)
        {
            personeels_ID = nPersoneel_ID;
            Voornaam = nVoornaam;
            Achternaam = nAchternaam;
            Telefoonnummer = nTelefoonnummer;
            Email = nEmail;
            Adres = nAdres;
            Gemeente = nGemeente;
            Functie = nFunctie;
            Paswoord = nPaswoord;
        }
        public Personeel() { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
