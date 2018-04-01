using AdoWagenpark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using AdoWagenpark;

namespace Wagenparkbeheren
{
    /// <summary>
    /// Interaction logic for InlogScherm.xaml
    /// </summary>
    public partial class InlogScherm : Window
    {

        public List<login> Logins = new List<login>();
        public InlogScherm()
        {
            InitializeComponent();
        }


        private void buttonInloggen_Click(object sender, RoutedEventArgs e)
        {




           
            var manager = new LoginManager();
            var Login = manager.Getverification(textBoxVoornaam.Text.ToString(), textBoxPaswoord.Password.ToString());
          




            //foreach(var eenlogin in allelogins)
            //{
            //  login.Add(eenlogin);
            //}





            if (Login.Count != 0)
            {
                startscherm win1 = new startscherm();
                win1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Uw gebruikersnaam en/of uw paswoord zijn niet correct", "verkeerde login", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }




        private void buttonAnnuleren_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /* private void btnSubmit_Click(object sender, RoutedEventArgs e)
         {
             try
             {
                 var manager = new LoginManager();


                 int login = Convert.ToInt32(manager.Getverification(textBoxVoornaam.Text.ToString(), textBoxPaswoord.Password));





                 if (login == 1)
                 {
                     startscherm win1 = new startscherm();
                     win1.Show();
                     this.Close();
                 }
                 else
                 {
                     MessageBox.Show("Uw gebruikersnaam en/of uw paswoord zijn niet correct", "verkeerde login", MessageBoxButton.OK, MessageBoxImage.Error);
                 }

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }*/
    }
}

