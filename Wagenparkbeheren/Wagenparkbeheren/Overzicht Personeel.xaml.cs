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
    /// Interaction logic for Overzicht_Personeel.xaml
    /// </summary>
    public partial class Overzicht_Personeel : Window
    {

        public ObservableCollection<Personeel> personeelOb = new ObservableCollection<Personeel>();


        /*variabelen class*/
        private CollectionViewSource personeelViewSource;

        public Overzicht_Personeel()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //System.Windows.Data.CollectionViewSource personeelViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("personeelViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // personeelViewSource.Source = [generic data source]

            VulDeGrid();
        }

        private void VulDeGrid()
        {
          
            int totalRowscount;
            personeelViewSource = (CollectionViewSource)(this.FindResource("personeelViewSource"));
            var manager = new personeelManager();
            

            personeelOb = manager.GetPersoneelNaam(textBoxZoeken.Text);
            totalRowscount = personeelOb.Count();
            
           personeelViewSource.Source = personeelOb;
           
            
            

        }

        private void textBoxZoeken_TextChanged(object sender, TextChangedEventArgs e)
        {
            VulDeGrid();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            PersoneelToevoegen win4 = new PersoneelToevoegen();
            win4.Show();
            
        }

        private void Returnbutton_Click(object sender, RoutedEventArgs e)
        {
            startscherm win1 = new startscherm();
            win1.Show();
            this.Close();
        }
    }
}
