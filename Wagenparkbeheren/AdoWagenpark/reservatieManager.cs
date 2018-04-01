using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoWagenpark
{
  public class reservatieManager
    {
        public ObservableCollection<reservatie> GetReservatie()
        {
            ObservableCollection<reservatie> reservatie = new ObservableCollection<reservatie>();
            var manager = new WagenparkDBManager();
            using (var conReservatie = manager.GetConnection())
            {
                using (var comReservatie = conReservatie.CreateCommand())
                {
                    comReservatie.CommandType = CommandType.Text;
                 
                        comReservatie.CommandText = "SELECT * FROM reservatie";
                    
                    conReservatie.Open();


                    using (var rdrReservatie = comReservatie.ExecuteReader())
                    {

                        Int32 Reservatie_IDPos = rdrReservatie.GetOrdinal("Reservatie_ID");
                        Int32 Personeel_IDPos = rdrReservatie.GetOrdinal("Personeels_ID");
                        Int32 Wagen_IDPos = rdrReservatie.GetOrdinal("Wagen_ID");
                        Int32 StartdatumPos = rdrReservatie.GetOrdinal("Startdatum");
                        Int32 EinddatumPos = rdrReservatie.GetOrdinal("Einddatum");
                       



                        while (rdrReservatie.Read())
                        {
                            reservatie.Add(new reservatie(  rdrReservatie.GetInt32(Reservatie_IDPos),
                                                            rdrReservatie.GetInt32(Personeel_IDPos),
                                                            rdrReservatie.GetInt32(Wagen_IDPos),
                                                            rdrReservatie.GetDateTime(StartdatumPos),
                                                            rdrReservatie.GetDateTime(EinddatumPos)));
                                            


                        }



                    }
                }
            
        }

            return reservatie;

        }

        public Int64 NieuweReservatie(String Personeels_ID, String Wagen_ID, DateTime Startdatum, DateTime Einddatum)

        {
            var manager = new WagenparkDBManager();
            using (var conReservatie = manager.GetConnection())
            {
                using (var comReservatie = conReservatie.CreateCommand())
                {
                    comReservatie.CommandType = CommandType.StoredProcedure;
                    comReservatie.CommandText = "NieweReservatie";

                    var parPersoneelID = comReservatie.CreateParameter();
                    parPersoneelID.ParameterName = "@Personeels_ID";
                    parPersoneelID.Value = Personeels_ID;

                    var parWagenID = comReservatie.CreateParameter();
                    parWagenID.ParameterName = "@Wagen_ID";
                    parWagenID.Value = Wagen_ID;

                    var parStartdatum = comReservatie.CreateParameter();
                    parStartdatum.ParameterName = "@Startdatum";
                    parStartdatum.Value = Startdatum;

                    var parEinddatum = comReservatie.CreateParameter();
                    parEinddatum.ParameterName = "@Einddatum";
                    parEinddatum.Value = Einddatum;




                    comReservatie.Parameters.Add(parPersoneelID);
                    comReservatie.Parameters.Add(parWagenID);
                    comReservatie.Parameters.Add(parStartdatum);
                    comReservatie.Parameters.Add(parEinddatum);


                    conReservatie.Open();

                    Int64 Reservatie_ID = Convert.ToInt64(comReservatie.ExecuteScalar());
                    return Reservatie_ID;
                }
            }


        }

        public ObservableCollection<reservatie> Reservatie()
        {
            ObservableCollection<Personeel> personeel = new ObservableCollection<Personeel>();
            ObservableCollection<reservatie> reservatie = new ObservableCollection<reservatie>();
            var manager = new WagenparkDBManager();
            using (var conReservatie = manager.GetConnection())
            {
                using (var comReservatie = conReservatie.CreateCommand())
                {
                    comReservatie.CommandType = CommandType.StoredProcedure;

                    comReservatie.CommandText = "Inheritance";

                    conReservatie.Open();


                    using (var rdrReservatie = comReservatie.ExecuteReader())
                    {

                        Int32 Reservatie_IDPos = rdrReservatie.GetOrdinal("Reservatie_ID");
                        Int32 Personeel_IDPos = rdrReservatie.GetOrdinal("Personeels_ID");
                        Int32 Wagen_IDPos = rdrReservatie.GetOrdinal("Wagen_ID");
                        Int32 StartdatumPos = rdrReservatie.GetOrdinal("Startdatum");
                        Int32 EinddatumPos = rdrReservatie.GetOrdinal("Einddatum");




                        while (rdrReservatie.Read())
                        {
                            reservatie.Add(new reservatie(rdrReservatie.GetInt32(Reservatie_IDPos),
                                                            rdrReservatie.GetInt32(Personeel_IDPos),
                                                            rdrReservatie.GetInt32(Wagen_IDPos),
                                                            rdrReservatie.GetDateTime(StartdatumPos),
                                                            rdrReservatie.GetDateTime(EinddatumPos)));



                        }

                        
                    }

                }

                return reservatie;

            }

        }


    }
}
