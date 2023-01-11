using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooop6
{
    internal class Osoba
    {
        protected string jmeno;
        protected string prijmeni;
        protected int hmotnost;
        protected double vyska;
        protected string Jmeno { get => jmeno; set => jmeno = value; }
        
        
        protected string Prijmeni { get => prijmeni; set => prijmeni = value; }
       
        protected int Hmotnost
        {
            get => hmotnost;
            set
            {
                if (value > 300)
                {
                    MessageBox.Show("Hmotnost mimo rozsah!!");
                }
                else
                {
                    hmotnost = value;
                }
            }
        }
        protected double Vyska
        {
            get => vyska;
            set
            {
                if (value > 3) 
                    vyska = value / 100;
                else
                    vyska = value;
            }
           
        }

        public Osoba(string jmeno, string prijmeni, double vyska, int hmotnost)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            Hmotnost = hmotnost;
            Vyska = vyska;           
        }

        public double BMI()
        {
            return hmotnost / (vyska * vyska);
        }

        public override string ToString()
        {
            return String.Format("{0} {1} \nVýška: {2}m\nHmostnost: {3}kg\nBMI: {4}\n", jmeno, prijmeni, vyska, hmotnost, BMI());
        }

    }
}
