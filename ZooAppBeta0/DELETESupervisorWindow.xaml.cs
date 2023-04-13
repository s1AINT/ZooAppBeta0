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
    /// Interaction logic for DELETESupervisorWindow.xaml
    /// </summary>
    public partial class DELETESupervisorWindow : Window
    {
        public DELETESupervisorWindow()
        {
            InitializeComponent();
        }
        private void ButtonBackToSuperOperWindow(object sender, RoutedEventArgs e)
        {
            SupervisorsOperationsWindow superOperWind = new SupervisorsOperationsWindow();
            superOperWind.Show();
            this.Hide();
        }
        private void ButtonToDELETESupervisorClick(object sender, RoutedEventArgs e)
        {
            /*
            AnimalsOperations animalsOperations = new AnimalsOperations();
            animalsOperations.Show();
            this.Hide();*/
        }
    }
}
