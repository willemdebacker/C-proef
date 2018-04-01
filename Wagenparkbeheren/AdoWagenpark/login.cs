using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoWagenpark
{
   public class login
    {

        private String voornaam;
        private String paswoord;
        

        public string Voornaam
        {
            get { return voornaam; }
            set { voornaam = value; }
        }

        public String Paswoord
        {
            get { return paswoord; }
            set { paswoord = value; }
        }

        public login (String nVoornaam, String nPaswoord)
        {
            Voornaam = nVoornaam;
            Paswoord = nPaswoord;
        }
        public login() { }
    }
}
