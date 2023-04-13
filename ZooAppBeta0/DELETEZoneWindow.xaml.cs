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
    /// Interaction logic for DELETEZoneWindow.xaml
    /// </summary>
    public partial class DELETEZoneWindow : Window
    {
        public DELETEZoneWindow()
        {
            InitializeComponent();
        }
        private void ButtonBackToZonesOperWindow(object sender, RoutedEventArgs e)
        {
            ZonesOperationsWindow zoneOperWind = new ZonesOperationsWindow();
            zoneOperWind.Show();
            this.Hide();
        }

        private void ButtonToDELETEVeterinarianClick(object sender, RoutedEventArgs e)
        {
            ZonesOperationsWindow zoneOperWind = new ZonesOperationsWindow();
            zoneOperWind.Show();
            this.Hide();
        }
        
    }
}
