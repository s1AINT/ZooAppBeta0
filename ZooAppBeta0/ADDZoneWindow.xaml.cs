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

namespace ZooAppBeta0
{
    /// <summary>
    /// Interaction logic for ADDZoneWindow.xaml
    /// </summary>
    public partial class ADDZoneWindow : Window
    {
        public ADDZoneWindow()
        {
            InitializeComponent();
        }

        private void ButtonBackToZoneOperWindow(object sender, RoutedEventArgs e)
        {
            ZonesOperationsWindow zoneOperWind = new ZonesOperationsWindow();
            zoneOperWind.Show();
            this.Hide();
        }
        private void ButtonToADDZoneClick(object sender, RoutedEventArgs e)
        {
            string name = textBoxName.Text;
            string characteristic = textBoxCharacteristic.Text;

            Zone newZone = new Zone(name, characteristic);
        }

        private void textBoxAnimalFir_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
