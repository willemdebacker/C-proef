using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoWagenpark
{
   public class reservatie:Personeel
    {

        //overerving toepassen 

        private Int32 reservatie_ID;
        private Int32 personeels_ID;
        private Int32 wagen_ID;
        private DateTime startdatum;
        private DateTime einddatum;
      
        

        public Int32 Reservatie_ID
        {
            get { return reservatie_ID; }
        }

        public Int32 Personeels_ID
        {
            get { return personeels_ID; }
            set { personeels_ID = value; }
        }

        public Int32 Wagen_ID
        {
            get { return wagen_ID;}
            set { wagen_ID = value; }
        }

        public DateTime Startdatum
        {
            get { return startdatum; }
            set { startdatum = value; }
        }

        public DateTime Einddatum
        {
            get { return einddatum; }
            set { einddatum = value; }
        }


        public reservatie(Int32 nReservatie_ID, Int32 nPersoneel_ID, Int32 nWagen_ID, DateTime nStartdatum, DateTime nEinddatum)
        {
            reservatie_ID = nReservatie_ID;
            Personeels_ID = nPersoneel_ID;
            Wagen_ID = nWagen_ID;
            Startdatum = nStartdatum;
            Einddatum = nEinddatum;
        }
       
        public void Personeel() { }
       

        public reservatie() { }


        public override string ToString()
        {
            return base.ToString();
            
        }
    }
}
