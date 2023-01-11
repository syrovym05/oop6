using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooop6
{
    internal class Pacient : Osoba
    {
        double obvodPasu;
        double ObvodPasu 
        { 
            get => obvodPasu;
            set 
            {
                if (value > 2) obvodPasu = value / 100;
                else obvodPasu = value;
            }
        }

        public Pacient(string jmeno, string prijmeni, double vyska, int hmotnost, double obvodPasu) : base(jmeno, prijmeni, vyska, hmotnost)
        {
            ObvodPasu = obvodPasu;
        }

        double ABSI()
        {
            return obvodPasu / (Math.Pow(BMI(),2/3) * Math.Sqrt(vyska));
        }

        public override string ToString()
        {
            return base.ToString() +"ABSI: "+ ABSI();
        }
    }
}
