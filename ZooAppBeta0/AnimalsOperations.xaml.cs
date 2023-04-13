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
    /// Interaction logic for AnimalsOperations.xaml
    /// </summary>
    public partial class AnimalsOperations : Window
    {
        public AnimalsOperations()
        {
            InitializeComponent();
        }
        private void ButtonBackToMainMenuClick(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
        private void ButtonADDAnimalClick(object sender, RoutedEventArgs e)
        {
            ADDAnimalWindow addAnimalWindow = new ADDAnimalWindow();
            addAnimalWindow.Show();
            this.Hide();
        }

        private void ButtonDELETEAnimalClick(object sender, RoutedEventArgs e)
        {
            DELETEAnimalWindow dELETEAnimalWindow = new DELETEAnimalWindow();
            dELETEAnimalWindow.Show();
            this.Hide();
        }

    }
}