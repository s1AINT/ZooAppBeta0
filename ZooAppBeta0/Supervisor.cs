using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAppBeta0
{
    class Supervisor
    {
        public int ID { get; set; }
        private string name, birthday, phone_number;
        private int id_of_marital_status, animalF, animalS, animalT;


        public int Id_of_marital_status
        {
            get { return id_of_marital_status; }
            set { id_of_marital_status = value; }
        }

        public int AnimalF
        {
            get { return animalF; }
            set { animalF = value; }
        }

        public int AnimalS
        {
            get { return animalS; }
            set { animalS = value; }
        }

        public int AnimalT
        {
            get { return animalT; }
            set { animalT = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public string Phone_number
        {
            get { return phone_number; }
            set { phone_number = value; }
        }

        public Supervisor () { }

        public Supervisor (string name, string birthday, string phone_number, int id_of_marital_status, int animalF, int animalS, int animalT)
        {
            this.name = name;
            this.birthday = birthday;
            this.phone_number = phone_number;
            this.id_of_marital_status = id_of_marital_status;
            this.animalF = animalF;
            this.animalS = animalS;
            this.animalT = animalT;
        }

        public Supervisor(string name, string birthday, string phone_number, int id_of_marital_status)
        {
            this.name = name;
            this.birthday = birthday;
            this.phone_number = phone_number;
            this.id_of_marital_status = id_of_marital_status;
        }
    }
}
