using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoWagenpark
{
    public class personeelManager
    {
        public ObservableCollection<Personeel> GetPersoneelNaam(string Naam)
        {
            ObservableCollection<Personeel> personeel = new ObservableCollection<Personeel>();
            var manager = new WagenparkDBManager();
            using (var conPersoon = manager.GetConnection())
            {
                using (var comPersoon = conPersoon.CreateCommand())
                {
                    comPersoon.CommandType = CommandType.Text;
                    if (Naam != string.Empty)
                    {
                        comPersoon.CommandText =
                        "SELECT personeels_ID, voornaam, achternaam, telefoonnummer, email, adres, gemeente, functie, Paswoord FROM Personeel WHERE Achternaam Like @Naam order by Personeels_ID";

                        var parNaam = comPersoon.CreateParameter();
                        parNaam.ParameterName = "@Naam";
                        parNaam.Value = Naam + "%";
                        comPersoon.Parameters.Add(parNaam);
                    }
                    else 
                    {
                        comPersoon.CommandText = "SELECT personeels_ID, voornaam, achternaam, telefoonnummer, email, adres, gemeente, functie, Paswoord FROM Personeel order by Personeels_ID";
                    }
                    conPersoon.Open();

                   
                    using (var rdrPersoneel = comPersoon.ExecuteReader())
                    {

                        Int32 Personeel_IDPos = rdrPersoneel.GetOrdinal("Personeels_ID");
                        Int32 VoornaamPos = rdrPersoneel.GetOrdinal("Voornaam");
                        Int32 AchternaamPos = rdrPersoneel.GetOrdinal("Achternaam");
                        Int32 TelefoonnummerPos = rdrPersoneel.GetOrdinal("Telefoonnummer");
                        Int32 EmailPos = rdrPersoneel.GetOrdinal("Email");
                        Int32 AdresPos = rdrPersoneel.GetOrdinal("Adres");
                        Int32 GemeentePos = rdrPersoneel.GetOrdinal("Gemeente");
                        Int32 FunctiePos = rdrPersoneel.GetOrdinal("Functie");
                        Int32 PaswoordPos = rdrPersoneel.GetOrdinal("Paswoord");
            

                        while (rdrPersoneel.Read())
                        {
                            personeel.Add( new Personeel( rdrPersoneel.GetInt32(Personeel_IDPos), 
                                            rdrPersoneel.GetString(VoornaamPos), 
                                            rdrPersoneel.GetString(AchternaamPos),
                                            rdrPersoneel.GetString(TelefoonnummerPos),
                                            rdrPersoneel.GetString(EmailPos),
                                            rdrPersoneel.GetString(AdresPos),
                                            rdrPersoneel.GetString(GemeentePos),
                                            rdrPersoneel.GetString(FunctiePos)
                                          , rdrPersoneel.GetString(PaswoordPos)));


                        }



                    }
                }
            }

            return personeel;

        }

        public Int64 NieuwPersoneelslid(String Voornaam, String Achternaam, String Telefoonnummer, String Email, String Adres, String Gemeente,
            String Functie ,String Paswoord)
        {
            var manager = new WagenparkDBManager();
            using (var conPersoneel = manager.GetConnection())
            {
                using (var comPersoneel = conPersoneel.CreateCommand())
                {
                    comPersoneel.CommandType = CommandType.StoredProcedure;
                    comPersoneel.CommandText = "NiewPersoneelslid";

                    var parVoornaam = comPersoneel.CreateParameter();
                    parVoornaam.ParameterName = "@Voornaam";
                    parVoornaam.Value = Voornaam;

                    var parAchternaam = comPersoneel.CreateParameter();
                    parAchternaam.ParameterName = "@Achternaam";
                    parAchternaam.Value = Achternaam;

                    var parTelefoonnummer = comPersoneel.CreateParameter();
                    parTelefoonnummer.ParameterName = "@Telefoonnummer";
                    parTelefoonnummer.Value = Telefoonnummer;

                    var parEmail = comPersoneel.CreateParameter();
                    parEmail.ParameterName = "@Email";
                    parEmail.Value = Email;

                    var parAdres = comPersoneel.CreateParameter();
                    parAdres.ParameterName = "@Adres";
                    parAdres.Value = Adres;


                    var parGemeente = comPersoneel.CreateParameter();
                    parGemeente.ParameterName = "@Gemeente";
                    parGemeente.Value = Gemeente;

                    var parFunctie = comPersoneel.CreateParameter();
                    parFunctie.ParameterName = "@Functie";
                    parFunctie.Value = Functie;

                    var parPaswoord = comPersoneel.CreateParameter();
                    parPaswoord.ParameterName = "@Paswoord";
                    parPaswoord.Value = Paswoord;



                    comPersoneel.Parameters.Add(parVoornaam);
                    comPersoneel.Parameters.Add(parAchternaam);
                    comPersoneel.Parameters.Add(parTelefoonnummer);
                    comPersoneel.Parameters.Add(parEmail);
                    comPersoneel.Parameters.Add(parAdres);
                    comPersoneel.Parameters.Add(parGemeente);
                    comPersoneel.Parameters.Add(parFunctie);
                    comPersoneel.Parameters.Add(parPaswoord);

                    conPersoneel.Open();

                    Int64 Personeels_ID = Convert.ToInt64(comPersoneel.ExecuteScalar());
                    return Personeels_ID;
                }
            }

            
        }

        public ObservableCollection<Personeel> GetPersoneelDetail(String personeelsID)
        {
            ObservableCollection<Personeel> personeel = new ObservableCollection<Personeel>();
            var manager = new WagenparkDBManager();
            using (var conPersoon = manager.GetConnection())
            {
                using (var comPersoon = conPersoon.CreateCommand())
                {
                    comPersoon.CommandType = CommandType.Text;
                    
                        comPersoon.CommandText =
                        "SELECT * FROM Personeel WHERE Personeels_ID = @personeelsID order by Achternaam";

                        var parNaam = comPersoon.CreateParameter();
                        parNaam.ParameterName = "@personeelsID";
                        parNaam.Value = personeelsID;
                        comPersoon.Parameters.Add(parNaam);
                   
                    conPersoon.Open();


                    using (var rdrPersoneel = comPersoon.ExecuteReader())
                    {

                        Int32 Personeel_IDPos = rdrPersoneel.GetOrdinal("Personeels_ID");
                        Int32 VoornaamPos = rdrPersoneel.GetOrdinal("Voornaam");
                        Int32 AchternaamPos = rdrPersoneel.GetOrdinal("Achternaam");
                        Int32 TelefoonnummerPos = rdrPersoneel.GetOrdinal("Telefoonnummer");
                        Int32 EmailPos = rdrPersoneel.GetOrdinal("Email");
                        Int32 AdresPos = rdrPersoneel.GetOrdinal("Adres");
                        Int32 GemeentePos = rdrPersoneel.GetOrdinal("Gemeente");
                        Int32 FunctiePos = rdrPersoneel.GetOrdinal("Functie");
                        Int32 PaswoordPos = rdrPersoneel.GetOrdinal("Paswoord");


                        while (rdrPersoneel.Read())
                        {
                            personeel.Add(new Personeel(rdrPersoneel.GetInt32(Personeel_IDPos),
                                            rdrPersoneel.GetString(VoornaamPos),
                                            rdrPersoneel.GetString(AchternaamPos),
                                            rdrPersoneel.GetString(TelefoonnummerPos),
                                            rdrPersoneel.GetString(EmailPos),
                                            rdrPersoneel.GetString(AdresPos),
                                            rdrPersoneel.GetString(GemeentePos),
                                            rdrPersoneel.GetString(FunctiePos),
                                            rdrPersoneel.GetString(PaswoordPos)));


                        }



                    }
                }
            }

            return personeel;

        }


    }
}
