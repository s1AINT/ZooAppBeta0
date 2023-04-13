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
    /// Interaction logic for ADDAnimalWindow.xaml
    /// </summary>
    public partial class ADDAnimalWindow : Window
    {
        ApplicationContext DB;
        public ADDAnimalWindow()
        {
            InitializeComponent();
            DB = new ApplicationContext();
        }

        private void ButtonBackToAnimOperWindow(object sender, RoutedEventArgs e)
        {
            AnimalsOperations animalsOperations = new AnimalsOperations();
            animalsOperations.Show();
            this.Hide();
        }
        private void ButtonToADDAnimalClick(object sender, RoutedEventArgs e)
        {
            /*
            string Name = textBoxName.Text;
            string Species = textBoxSpecies.Text;
            string Birthday = textBoxBirthday.Text;
            int Feeding_ration = int.Parse(textBoxFeeding_ration.Text);
            int Zone = int.Parse(textBoxZone.Text);
            int Supervisor = int.Parse(textBoxSupervisor.Text);
            int Veterinarian = int.Parse(textBoxVeterinarian.Text);
            int Normal_temperature = int.Parse(textBoxNormal_temperature.Text);
            string Hibernation_period = textBoxHibernation_period.Text;
            string Wintering_place = textBoxWintering_place.Text;
            */
            

            string name = textBoxName.Text;
            string species = textBoxSpecies.Text;
            string birthday = textBoxBirthday.Text;
            int feeding_ration, zone;
            int supervisor;
            int veterinarian;
            int normal_temperature;
            string hibernation_period = textBoxHibernation_period.Text;
            string wintering_place = textBoxWintering_place.Text;
            /*

            int.TryParse(textBoxFeeding_ration.Text, out Feeding_ration);
   
            if (int.TryParse(textBoxZone.Text, out Zone))
            {

            }
            if (int.TryParse(textBoxSupervisor.Text, out Supervisor))
            {

            }
            if (int.TryParse(textBoxVeterinarian.Text, out Veterinarian))
            {

            }
            if (int.TryParse(textBoxNormal_temperature.Text, out Normal_temperature))
            {

            }


            */



            int.TryParse(textBoxFeeding_ration.Text, out feeding_ration);
            int.TryParse(textBoxZone.Text, out zone);
            int.TryParse(textBoxSupervisor.Text, out supervisor);
            int.TryParse(textBoxVeterinarian.Text, out veterinarian);
            int.TryParse(textBoxNormal_temperature.Text, out normal_temperature);

            Animal newAnimal = new Animal(name, species, birthday, feeding_ration, zone, supervisor,
                veterinarian, normal_temperature, hibernation_period, wintering_place);
            DB.Animals.Add(newAnimal);
            DB.SaveChanges();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
        
    }
}
