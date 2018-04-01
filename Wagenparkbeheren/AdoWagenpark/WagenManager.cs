using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace AdoWagenpark
{
   public class WagenManager
    {

        public ObservableCollection<Wagen> GetWagenNummerPlaat(string Soort)
        {
            ObservableCollection<Wagen> wagens = new ObservableCollection<Wagen>();
            var manager = new WagenparkDBManager();
            using (var conWagen = manager.GetConnection())
            {
                using (var comWagens = conWagen.CreateCommand())
                {
                    comWagens.CommandType = CommandType.Text;
                    if (Soort != string.Empty)
                    {
                        comWagens.CommandText =
                        "SELECT * FROM Wagen WHERE Soort = @Soort order by Merk";

                        var parSoort = comWagens.CreateParameter();
                        parSoort.ParameterName = "@Soort";
                        parSoort.Value =Soort;
                        comWagens.Parameters.Add(parSoort);
                    }
                    else if(Soort == "alle wagens")
                    {
                        comWagens.CommandText = "SELECT * FROM Wagen order by Nummerplaat";
                    }
                    conWagen.Open();

                    /**executereader class**/
                    using (var rdrWagens = comWagens.ExecuteReader())
                    {
                        Int32 Wagen_IDPos = rdrWagens.GetOrdinal("Wagen_ID");
                        Int32 Wagenpark_IDPos = rdrWagens.GetOrdinal("Wagenpark_ID");
                        Int32 NummerplaatPos = rdrWagens.GetOrdinal("Nummerplaat");
                        Int32 MerkPos = rdrWagens.GetOrdinal("Merk");
                        Int32 TypePos = rdrWagens.GetOrdinal("Type");
                        Int32 KleurPos = rdrWagens.GetOrdinal("Kleur");
                        Int32 SoortPos = rdrWagens.GetOrdinal("Soort");



                        while (rdrWagens.Read())
                        {
                            wagens.Add(new Wagen(rdrWagens.GetInt32(Wagen_IDPos),
                                        rdrWagens.GetInt32(Wagenpark_IDPos),
                                        rdrWagens.GetString(NummerplaatPos),
                                        rdrWagens.GetString(MerkPos),
                                        rdrWagens.GetString(TypePos),
                                        rdrWagens.GetString(KleurPos),
                                        rdrWagens.GetString(SoortPos)));


                        }



                    }
                }
            }

            return wagens;

        }

      

        public ObservableCollection<soortwagen> GetSoortWagen()
        {
            ObservableCollection<soortwagen> wagens = new ObservableCollection<soortwagen>();
            var manager = new WagenparkDBManager();
            using (var conWagen = manager.GetConnection())
            {
                using (var comWagens = conWagen.CreateCommand())
                {
                    comWagens.CommandType = CommandType.Text;

                    comWagens.CommandType = CommandType.Text;
                    comWagens.CommandText = "  SELECT Soort FROM Wagen Group by Soort";




                    conWagen.Open();

                    /**executereader class**/
                    using (var rdrWagens = comWagens.ExecuteReader())
                    {
                     
                        Int32 SoortPos = rdrWagens.GetOrdinal("Soort");



                        while (rdrWagens.Read())
                        {
                            wagens.Add(new soortwagen(
                                        rdrWagens.GetString(SoortPos)));


                        }



                    }
                }
            }

            return wagens;

        }


        public ObservableCollection<Wagen> GetWagen()
        {
            ObservableCollection<Wagen> wagens = new ObservableCollection<Wagen>();
            var manager = new WagenparkDBManager();
            using (var conWagen = manager.GetConnection())
            {
                using (var comWagens = conWagen.CreateCommand())
                {
                    comWagens.CommandType = CommandType.Text;
                  
                
                        comWagens.CommandText = "SELECT * FROM Wagen order by Merk";
                    
                    conWagen.Open();

                    /**executereader class**/
                    using (var rdrWagens = comWagens.ExecuteReader())
                    {
                        Int32 Wagen_IDPos = rdrWagens.GetOrdinal("Wagen_ID");
                        Int32 Wagenpark_IDPos = rdrWagens.GetOrdinal("Wagenpark_ID");
                        Int32 NummerplaatPos = rdrWagens.GetOrdinal("Nummerplaat");
                        Int32 MerkPos = rdrWagens.GetOrdinal("Merk");
                        Int32 TypePos = rdrWagens.GetOrdinal("Type");
                        Int32 KleurPos = rdrWagens.GetOrdinal("Kleur");
                        Int32 SoortPos = rdrWagens.GetOrdinal("Soort");



                        while (rdrWagens.Read())
                        {
                            wagens.Add(new Wagen(rdrWagens.GetInt32(Wagen_IDPos),
                                        rdrWagens.GetInt32(Wagenpark_IDPos),
                                        rdrWagens.GetString(NummerplaatPos),
                                        rdrWagens.GetString(MerkPos),
                                        rdrWagens.GetString(TypePos),
                                        rdrWagens.GetString(KleurPos),
                                        rdrWagens.GetString(SoortPos)));


                        }



                    }
                }
            }

            return wagens;

        }

        public ObservableCollection<Wagen> GetWagendetails(Int32 Wagen_ID)
        {
            ObservableCollection<Wagen> wagens = new ObservableCollection<Wagen>();
            var manager = new WagenparkDBManager();
            using (var conWagen = manager.GetConnection())
            {
                using (var comWagens = conWagen.CreateCommand())
                {
                    comWagens.CommandType = CommandType.Text;
                    comWagens.CommandText = "SELECT * FROM Wagen as w JOIN Reservatie as r ON w.Wagen_ID = r.Wagen_ID Where w.Wagen_ID = @Wagen_ID";

                    var parWagenID = comWagens.CreateParameter();
                    parWagenID.ParameterName = "@Wagen_ID";
                    parWagenID.Value = Wagen_ID;
                    comWagens.Parameters.Add(parWagenID);

                    conWagen.Open();

                    /**executereader class**/
                    using (var rdrWagens = comWagens.ExecuteReader())
                    {
                        Int32 Wagen_IDPos = rdrWagens.GetOrdinal("Wagen_ID");
                        Int32 Wagenpark_IDPos = rdrWagens.GetOrdinal("Wagenpark_ID");
                        Int32 NummerplaatPos = rdrWagens.GetOrdinal("Nummerplaat");
                        Int32 MerkPos = rdrWagens.GetOrdinal("Merk");
                        Int32 TypePos = rdrWagens.GetOrdinal("Type");
                        Int32 KleurPos = rdrWagens.GetOrdinal("Kleur");
                        Int32 SoortPos = rdrWagens.GetOrdinal("Soort");



                        while (rdrWagens.Read())
                        {
                            wagens.Add(new Wagen(rdrWagens.GetInt32(Wagen_IDPos),
                                        rdrWagens.GetInt32(Wagenpark_IDPos),
                                        rdrWagens.GetString(NummerplaatPos),
                                        rdrWagens.GetString(MerkPos),
                                        rdrWagens.GetString(TypePos),
                                        rdrWagens.GetString(KleurPos),
                                        rdrWagens.GetString(SoortPos)));


                        }



                    }
                }
            }

            return wagens;

        }





    }
}
