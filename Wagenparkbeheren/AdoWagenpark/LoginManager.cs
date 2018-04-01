using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoWagenpark
{
    public class LoginManager
    {
        public ObservableCollection<login> Getverification(string Gebruikersnaam, string Paswoord)
        {
            ObservableCollection<login> personeel = new ObservableCollection<login>();
            var manager = new WagenparkDBManager();
            using (var conlogin = manager.GetConnection())
            {
                using (var comlogin = conlogin.CreateCommand())
                {
                    comlogin.CommandType = CommandType.StoredProcedure;
                    comlogin.CommandText = "LoginP";

                    var parNaam = comlogin.CreateParameter();
                    parNaam.ParameterName = "@Gebruikersnaam";
                    parNaam.Value = Gebruikersnaam;
                    comlogin.Parameters.Add(parNaam);

                    var parPaswoord = comlogin.CreateParameter();
                    parPaswoord.ParameterName = "@Paswoord";
                    parPaswoord.Value = Paswoord;
                    comlogin.Parameters.Add(parPaswoord);

                    


                    conlogin.Open();


                   using (var rdrlogin = comlogin.ExecuteReader())
                    {

                       
                        Int32 VoornaamPos = rdrlogin.GetOrdinal("Voornaam");
                        Int32 PaswoordPos = rdrlogin.GetOrdinal("Paswoord");


                        while (rdrlogin.Read())
                        {
                            personeel.Add(new login( rdrlogin.GetString(VoornaamPos), rdrlogin.GetString(PaswoordPos)));


                        }


                    }
                    }
                }
            return personeel;
        }

        public ObservableCollection<Gebruikersnaam> Getgebruikersnaam(string Naam)
        {
            ObservableCollection<Gebruikersnaam> personeel = new ObservableCollection<Gebruikersnaam>();
            var manager = new WagenparkDBManager();
            using (var conPersoon = manager.GetConnection())
            {
                using (var comPersoon = conPersoon.CreateCommand())
                {
                    comPersoon.CommandType = CommandType.Text;

                    comPersoon.CommandText =
                    "SELECT  Count(Voornaam) FROM Personeel Where Voornaam = @Voornaam";

                    var parNaam = comPersoon.CreateParameter();
                    parNaam.ParameterName = "@Voornaam";
                    parNaam.Value = Naam;
                    comPersoon.Parameters.Add(parNaam);


                    conPersoon.Open();


                    using (var rdrPersoneel = comPersoon.ExecuteReader())
                    {

                       
                        Int32 VoornaamPos = rdrPersoneel.GetOrdinal("Voornaam");
                     


                        while (rdrPersoneel.Read())
                        {
                            personeel.Add(new Gebruikersnaam(
                                            rdrPersoneel.GetString(VoornaamPos)));


                        }


                    }
                }
            }
            return personeel;
        }


        public ObservableCollection<Paswoord> GetPaswoord( string paswoord)
        {
            ObservableCollection<Paswoord> personeel = new ObservableCollection<Paswoord>();
            var manager = new WagenparkDBManager();
            using (var conPersoon = manager.GetConnection())
            {
                using (var comPersoon = conPersoon.CreateCommand())
                {
                    comPersoon.CommandType = CommandType.Text;

                    comPersoon.CommandText =
                    "SELECT Count(Paswoord) FROM Personeel Where Paswoord = @Paswoord ";

                    var parPaswoord = comPersoon.CreateParameter();
                    parPaswoord.ParameterName = "@Paswoord";
                    parPaswoord.Value = paswoord;
                    comPersoon.Parameters.Add(parPaswoord);


                    conPersoon.Open();


                    using (var rdrPersoneel = comPersoon.ExecuteReader())
                    {

                        Int32 PaswoordPos = rdrPersoneel.GetOrdinal("Paswoord");


                        while (rdrPersoneel.Read())
                        {
                            personeel.Add(new Paswoord( rdrPersoneel.GetString(PaswoordPos)));


                        }


                    }
                }
            }
            return personeel;
        }

    }
}
