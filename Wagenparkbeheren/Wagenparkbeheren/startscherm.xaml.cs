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
    /// Interaction logic for startscherm.xaml
    /// </summary>
    public partial class startscherm : Window
    {
        public startscherm()
        {
            InitializeComponent();
        }

        private void OverzichtPersoneelButton_Click(object sender, RoutedEventArgs e)
        {
            Overzicht_Personeel win2 = new Overzicht_Personeel();
            win2.Show();
            this.Close();
        }

        private void OverzichtWagensButton_Click(object sender, RoutedEventArgs e)
        {
            Overzicht_Wagens win3 = new  Overzicht_Wagens();
            win3.Show();
            this.Close();
        }

        private void OverzichtReservatiesButton_Click(object sender, RoutedEventArgs e)
        {
            Overzicht_reservaties win5 = new Overzicht_reservaties();
            win5.Show();
            this.Close();
        }

        private void AfmeldenButton_Click(object sender, RoutedEventArgs e)
        {
            InlogScherm win1 = new InlogScherm();
            win1.Show();
            this.Close();
        }
    }
}
