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
    /// Interaction logic for Reservatie_Toevoegen.xaml
    /// </summary>
    public partial class Reservatie_Toevoegen : Window
    {
        public Reservatie_Toevoegen()
        {
            InitializeComponent();
        }

        private void buttonannuleren_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttontoevoegen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var manager = new reservatieManager();

                manager.NieuweReservatie(textBoxPersoneelsID.Text.ToString(), textBoxWagenID.Text.ToString(),
                                            datePickerstartdatum.SelectedDate.Value, datePickerEinddatum.SelectedDate.Value);
                labelStatus.Content = "Reservatie succesvol toegevoegd";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
