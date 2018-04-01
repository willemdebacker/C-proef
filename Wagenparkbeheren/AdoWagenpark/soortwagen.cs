using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoWagenpark
{
    public class soortwagen
    {
        private String soort; 

        public String Soort
        {
            get { return soort; }
            set { soort = value; }

      
        }

        public soortwagen (String nSoort)
        {
            Soort = nSoort;
        }

        public soortwagen() { }

        public override string ToString()
        {
            return Soort;
        }
    }
}
