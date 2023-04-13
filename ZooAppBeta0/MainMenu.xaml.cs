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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void ButtonAnimalsOperationsClick (object sender, RoutedEventArgs e)
        {
            AnimalsOperations animalsOperations = new AnimalsOperations();
            animalsOperations.Show();
            this.Hide();
        }
        private void ButtonSupervisorsOperationsClick(object sender, RoutedEventArgs e)
        {
            SupervisorsOperationsWindow supervisorsOperationsWindow = new SupervisorsOperationsWindow();
            supervisorsOperationsWindow.Show();
            this.Hide();
        }
        private void ButtonVeterinariansOperationsClick(object sender, RoutedEventArgs e)
        {
            VeterinariansOperationsWindow veterinariansOperationsWindow = new VeterinariansOperationsWindow();
            veterinariansOperationsWindow.Show();
            this.Hide();
        }

        private void ButtonZonesOperationsClick(object sender, RoutedEventArgs e)
        {
            ZonesOperationsWindow zonesOperationsWindow = new ZonesOperationsWindow();
            zonesOperationsWindow.Show();
            this.Hide();
        }
    }
}
