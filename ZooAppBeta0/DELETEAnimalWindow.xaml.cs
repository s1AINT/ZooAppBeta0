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
    /// Interaction logic for DELETEAnimalWindow.xaml
    /// </summary>
    public partial class DELETEAnimalWindow : Window
    {
        public DELETEAnimalWindow()
        {
            InitializeComponent();
        }

        private void ButtonBackToAnimOperWindow(object sender, RoutedEventArgs e)
        {
            AnimalsOperations animalsOperations = new AnimalsOperations();
            animalsOperations.Show();
            this.Hide();
        }
        private void ButtonToDELETEAnimalClick(object sender, RoutedEventArgs e)
        {
            /*
            AnimalsOperations animalsOperations = new AnimalsOperations();
            animalsOperations.Show();
            this.Hide();*/
        }
    }
}
