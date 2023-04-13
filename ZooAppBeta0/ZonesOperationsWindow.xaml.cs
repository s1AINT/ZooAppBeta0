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
    /// Interaction logic for ZonesOperationsWindow.xaml
    /// </summary>
    public partial class ZonesOperationsWindow : Window
    {
        public ZonesOperationsWindow()
        {
            InitializeComponent();
        }

        private void ButtonBackToMainMenuClick(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
        private void ButtonADDZoneClick(object sender, RoutedEventArgs e)
        {
            ADDZoneWindow addZoneWindow = new ADDZoneWindow();
            addZoneWindow.Show();
            this.Hide();
        }
        private void ButtonDELETEZoneClick(object sender, RoutedEventArgs e)
        {
            DELETEZoneWindow dETLETZoneWindow = new DELETEZoneWindow();
            dETLETZoneWindow.Show();
            this.Hide();
        }

    }
}
