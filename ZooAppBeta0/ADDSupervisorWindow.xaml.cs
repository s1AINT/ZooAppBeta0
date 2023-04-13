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
    /// Interaction logic for ADDSupervisorWindow.xaml
    /// </summary>
    public partial class ADDSupervisorWindow : Window
    {
        public ADDSupervisorWindow()
        {
            InitializeComponent();
        }

        private void ButtonBackToSuperOperWindow(object sender, RoutedEventArgs e)
        {
            SupervisorsOperationsWindow superOperWind = new SupervisorsOperationsWindow();
            superOperWind.Show();
            this.Hide();
        }
        private void ButtonToADDSupervisorClick(object sender, RoutedEventArgs e)
        {
            string name = textBoxName.Text;
            string birthday = textBoxBirthday.Text;
            string phone_number = textBoxPhone_number.Text;
            int id_of_marital_status, animalF, animalS, animalT;
            int.TryParse(textBoxIDMarStat.Text, out id_of_marital_status);

            Supervisor newSupervisor = new Supervisor(name, birthday, phone_number,
                id_of_marital_status);
        }
    }
}
