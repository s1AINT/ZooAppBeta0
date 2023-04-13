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
    /// Interaction logic for VeterinariansOperationsWindow.xaml
    /// </summary>
    public partial class VeterinariansOperationsWindow : Window
    {
        public VeterinariansOperationsWindow()
        {
            InitializeComponent();
        }
        private void ButtonBackToMainMenuClick(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void ButtonADDVeterinarianClick(object sender, RoutedEventArgs e)
        {
            ADDVeterinarianWindow aDDVeterinarianWindow = new ADDVeterinarianWindow();
            aDDVeterinarianWindow.Show();
            this.Hide();
        }
        private void ButtonDELETEVeterinarianClick(object sender, RoutedEventArgs e)
        {
            DELETEVeterinarianWindow dELETEVeterinarianWindow = new DELETEVeterinarianWindow();
            dELETEVeterinarianWindow.Show();
            this.Hide();
        }

    }
}
