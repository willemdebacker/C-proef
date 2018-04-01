using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoWagenpark
{
   public class Gebruikersnaam
    {
        private string gebruikersnaam;
        

        public string GebruikersNaam
        {
            get { return gebruikersnaam; }
            set { gebruikersnaam = value; }
        }

      

        public Gebruikersnaam ( string nGebruikersnaam)
        {
            GebruikersNaam = nGebruikersnaam;
            
        }

        public Gebruikersnaam() { }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
