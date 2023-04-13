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
    /// Interaction logic for SupervisorsOperationsWindow.xaml
    /// </summary>
    public partial class SupervisorsOperationsWindow : Window
    {
        public SupervisorsOperationsWindow()
        {
            InitializeComponent();
        }
        private void ButtonBackToMainMenuClick(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
        private void ButtonADDSupervisorClick(object sender, RoutedEventArgs e)
        {
            ADDSupervisorWindow aDDSupervisorWindow = new ADDSupervisorWindow();
            aDDSupervisorWindow.Show();
            this.Hide();
        }

        private void ButtonDELETESupervisorClick(object sender, RoutedEventArgs e)
        {
            DELETESupervisorWindow dELETESupervisorWindow = new DELETESupervisorWindow();
            dELETESupervisorWindow.Show();
            this.Hide();
        }
    }
}
