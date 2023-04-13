using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAppBeta0
{
    class Animal
    {
        public int ID { get; set; }
        
        private int Feeding_ration, zone, supervisor, veterinarian, normal_temperature;

        private string name, species, birthday, hibernation_period, wintering_place;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Species
        {
            get { return species; }
            set { species = value; }
        }

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public int feeding_ration
        {
            get { return Feeding_ration; }
            set { Feeding_ration = value; }
        }

        public int Zone
        {
            get { return zone; }
            set { zone = value; }
        }

        public int Supervisor
        {
            get { return supervisor; }
            set { supervisor = value; }
        }

        public int Veterinarian
        {
            get { return veterinarian; }
            set { veterinarian = value; }
        }

        public int Normal_temperature
        {
            get { return normal_temperature; }
            set { normal_temperature = value; }
        }

        public string Hibernation_period
        {
            get { return hibernation_period; }
            set { hibernation_period = value; }
        }

        public string Wintering_place
        {
            get { return wintering_place; }
            set { wintering_place = value; }
        }

        public Animal() { }

        public Animal(string name, string species, string birthday, int Feeding_ration, 
            int zone, int supervisor, int veterinarian, int normal_temperature, 
            string hibernation_period, string wintering_place)
        {
            this.name = name;
            this.species = species;
            this.birthday = birthday;
            this.feeding_ration = feeding_ration;
            this.zone = zone;
            this.supervisor = supervisor;
            this.veterinarian = veterinarian;
            this.normal_temperature = normal_temperature;
            this.hibernation_period = hibernation_period;
            this.wintering_place = wintering_place;
        }
    }
}
