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
using System.Collections.ObjectModel;

namespace Wagenparkbeheren
{
    /// <summary>
    /// Interaction logic for Overzicht_reservaties.xaml
    /// </summary>
    /// 

    public partial class Overzicht_reservaties : Window
    {

        public ObservableCollection<Wagen> wagenOb = new ObservableCollection<Wagen>();
        public ObservableCollection<Personeel> PersoneelOb = new ObservableCollection<Personeel>();


        /*variabelen class*/
        private CollectionViewSource personeelViewSource;
       // private CollectionViewSource reservatieViewSource;
        private CollectionViewSource wagenViewSource;


        public Overzicht_reservaties()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var reservatieManager = new reservatieManager();
            var alleReservaties = reservatieManager.Reservatie();
            foreach (var eenReservatie in alleReservaties)
            {
                reservatieDataGrid.Items.Add(eenReservatie);
            }



        }

        private void reservatieDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

           /* wagenViewSource = (CollectionViewSource)(this.FindResource("wagenViewSource"));
            var wagenmanager = new WagenManager();
           // string wagenid = reservatieDataGrid.SelectedCells.Contains();
            wagenOb = wagenmanager.GetWagendetails(Convert.ToInt32(reservatieDataGrid.SelectedItem) );
            

            wagenViewSource.Source = wagenOb;*/

            

            //var wagen_ID = reservatieDataGrid.SelectedItem.ToString();
           /* var wagenmanager = new WagenManager();
            var alleWagens = wagenmanager.GetWagendetails(wagen_IDColumn);
            foreach ( var eenWagen in alleWagens)
            {
                
                    wagen_IDTextBox.Text = eenWagen.Wagen_ID.ToString();
                    wagenpark_IDTextBox.Text = eenWagen.Wagenpark_ID.ToString();
                    nummerplaatTextBox.Text = eenWagen.Nummerplaat.ToString();
                    merkTextBox.Text = eenWagen.Merk.ToString();
                    typeTextBox.Text = eenWagen.Type.ToString();
                    kleurTextBox.Text = eenWagen.Kleur.ToString();
                    soortTextBox.Text = eenWagen.Soort.ToString();
                
            }*/
           /* var wagenmanager = new WagenManager();
            var wagendetails = wagenmanager.GetWagenDetail(Convert.ToInt32(wagen_IDTextBox.Text),Convert.ToInt32( wagenpark_IDTextBox.Text.ToString()),
                nummerplaatTextBox.Text.ToString(), merkTextBox.Text.ToString(), typeTextBox.Text.ToString(), kleurTextBox.Text.ToString(), 
                soortTextBox.Text.ToString());
            kleurTextBox.Text = wagendetails.Kleur.ToString();
            soortTextBox.Text = wagendetails.ToString();
            typeTextBox.Text = wagendetails.ToString();
            merkTextBox.Text = wagendetails.ToString();
            nummerplaatTextBox.Text = wagendetails.ToString();
            wagenpark_IDTextBox.Text = wagendetails.ToString();
            wagen_IDTextBox.Text = wagendetails.ToString();
            //personeelViewSource = (CollectionViewSource)(this.FindResource("personeelViewSource"));
            // var manager2 = new personeelManager();
            //List<Brouwer> brouwers = new List<Brouwer>();

            // PersoneelOb = manager2.GetPersoneelDetail(reservatieDataGrid.SelectedItem.ToString());


            //  personeelViewSource.Source = PersoneelOb;*/


        }

        private void buttonNieuweReservatie_Click(object sender, RoutedEventArgs e)
        {
            Reservatie_Toevoegen win6 = new Reservatie_Toevoegen();
            win6.Show(); 

        }

        private void buttonTerug_Click(object sender, RoutedEventArgs e)
        {
            startscherm win1 = new startscherm();
            win1.Show();
            this.Close();
        }

        private void buttonRefresh_Click(object sender, RoutedEventArgs e)
        {
            reservatieDataGrid.Items.Clear();
            var reservatieManager = new reservatieManager();
            var alleReservaties = reservatieManager.GetReservatie();
            foreach (var eenReservatie in alleReservaties)
            {
                reservatieDataGrid.Items.Add(eenReservatie);
            }

        }
    }
}
