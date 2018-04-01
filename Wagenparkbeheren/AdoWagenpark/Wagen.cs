using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoWagenpark
{
    public class Wagen:reservatie
    {
       private  Int32 Wagen_IDValue;
       private  Int32 Wagenpark_IDValue;
      private  String NummerplaatValue;
       private String MerkValue;
      private   String TypeValue;
       private String KleurValue;
       private String SoortValue; 

        public Int32 Wagen_ID
        {
            get { return Wagen_IDValue; }
            
        }

        public Int32 Wagenpark_ID
        {
            get { return Wagenpark_IDValue; }
            set { Wagenpark_IDValue = value; }
        }

        public String Nummerplaat
        {
            get { return NummerplaatValue; }
            set { NummerplaatValue = value; }
        }


        public String Merk
        {
            get { return MerkValue; }
            set { MerkValue = value; }
        }

        public String Type
        {
            get { return TypeValue; }
            set { TypeValue = value; }
        }

        public String Kleur
        {
            get { return KleurValue;  }
            set { KleurValue = value; }
        }

        public String Soort
        {
            get { return SoortValue;  }
            set { SoortValue = value; }
        }


        public Wagen() { }

        public Wagen(int wagen_ID, int wagenpark_ID, string nummerplaat, string merk, string type, string kleur, string soort)
        {
            Wagen_IDValue = wagen_ID;
            this.Wagenpark_ID = wagenpark_ID;
            this.Nummerplaat = nummerplaat;
            this.Merk = merk;
            this.Type = type;
            this.Kleur = kleur;
            this.Soort = soort;

        }
    }
}
