using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoWagenpark
{
   public class Paswoord
    {

        private string paswoord;


        public string PasWoord
        {
            get { return paswoord; }
            set { paswoord = value; }
            
        }



        public Paswoord(string nPaswoord)
        {
            PasWoord = nPaswoord;

        }

        public Paswoord() { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
