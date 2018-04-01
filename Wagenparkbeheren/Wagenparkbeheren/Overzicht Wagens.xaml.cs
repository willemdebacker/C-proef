using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Overzicht_Wagens.xaml
    /// </summary>
    public partial class Overzicht_Wagens : Window
    {


        public Overzicht_Wagens()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            try
            {
                var WagenManager = new WagenManager();
                var alleSoorten = WagenManager.GetSoortWagen();
                foreach (var eenSoort in alleSoorten)
                {
                    comboBoxSoorten.Items.Add(eenSoort);
                }
                comboBoxSoorten.Items.Add("Alle Wagens");

                var Wagenmanager = new WagenManager();
                var alleWagens = Wagenmanager.GetWagen();
                foreach ( var eenWagen in alleWagens)
                {
                    wagenDataGrid.Items.Add(eenWagen);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     
        private void comboBoxSoorten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                wagenDataGrid.Items.Clear();
                var soortWagen = ((soortwagen)comboBoxSoorten.SelectedItem).Soort;
                var wagenManager = new WagenManager();
                var alleWagens = wagenManager.GetWagenNummerPlaat(soortWagen);
                var soort = comboBoxSoorten.SelectedItem.ToString();
               

              
                
                    foreach (var eenWagen in alleWagens)
                    {
                        wagenDataGrid.Items.Add(eenWagen);
                    }

                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            startscherm win1 = new startscherm();
            win1.Show();
            this.Close();
        }
    }     
}
