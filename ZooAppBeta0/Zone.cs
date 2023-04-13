using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAppBeta0
{
    class Zone
    {
        public int ID { get; set; }
        private string name, characteristic;
        private int animalFir, animalSec, animalThr, animalFor, animalFiv;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Characteristic
        {
            get { return characteristic; }
            set { characteristic = value; }
        }

        public int AnimalFir
        {
            get { return animalFir; }
            set { animalFir = value; }
        }
        public int AnimalSec
        {
            get { return animalSec; }
            set { animalSec = value; }
        }
        public int AnimalThr
        {
            get { return animalThr; }
            set { animalThr = value; }
        }
        public int AnimalFor
        {
            get { return animalFor; }
            set { animalFor = value; }
        }
        public int AnimalFiv
        {
            get { return animalFiv; }
            set { animalFiv = value; }
        }

        public Zone () { }
        public Zone(string name, string characteristic, int animalFir,
            int animalSec, int animalThr, int animalFor, int animalFiv)
        {
            this.name = name;
            this.characteristic = characteristic;
            this.animalFir = animalFir;
            this.animalSec = animalSec;
            this.animalThr = animalThr;
            this.animalFor = animalFor;
            this.animalFiv = animalFiv;
        }

        public Zone(string name, string characteristic)
        {
            this.name = name;
            this.characteristic = characteristic;
        }
    }
}
