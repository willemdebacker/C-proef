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
using AdoWagenpark;
namespace Wagenparkbeheren
{
    /// <summary>
    /// Interaction logic for PersoneelToevoegen.xaml
    /// </summary>
    public partial class PersoneelToevoegen : Window
    {
        public PersoneelToevoegen()
        {
            InitializeComponent();
        }

        private void buttonAnnuleren_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonToevoegen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var manager = new personeelManager();

                manager.NieuwPersoneelslid(textBoxVoornaam.Text.ToString(),textBoxAchternaam.Text.ToString(), 
                                            textBoxTelefoonnummer.Text.ToString(), textBoxEmail.Text.ToString(),
                                            textBoxAdres.Text.ToString(), textBoxGemeente.Text.ToString(), textBoxFunctie.Text.ToString(), textBoxPaswoord.Text.ToString());
                labelstatus.Content = "Personeelslid succesvol toegevoegd";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
