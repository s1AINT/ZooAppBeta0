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
    /// Interaction logic for ADDVeterinarianWindow.xaml
    /// </summary>
    public partial class ADDVeterinarianWindow : Window
    {
        public ADDVeterinarianWindow()
        {
            InitializeComponent();
        }


        private void ButtonBackToVeterOperWindow(object sender, RoutedEventArgs e)
        {
            VeterinariansOperationsWindow veterOperWind = new VeterinariansOperationsWindow();
            veterOperWind.Show();
            this.Hide();
        }
        private void ButtonToADDVeterinarianClick(object sender, RoutedEventArgs e)
        {
            string name = textBoxName.Text;
            string birthday = textBoxBirthday.Text;
            string phone_number = textBoxPhone_number.Text;
            int id_of_marital_status, animalF, animalS, animalT;
            int.TryParse(textBoxIDMarStat.Text, out id_of_marital_status);

            Veterinarian newVeterinarian = new Veterinarian(name, birthday, phone_number,
                id_of_marital_status);
        }
    }
}
