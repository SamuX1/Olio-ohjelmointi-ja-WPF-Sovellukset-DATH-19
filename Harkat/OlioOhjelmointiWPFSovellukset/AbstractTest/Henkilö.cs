using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractTest
{
    abstract class Henkilö
    {
        public abstract string Nimi { get; set; }

        private static int instanssit = 0;

        public Henkilö()
        {
            instanssit++;
        }

        public static void KuinkaMonta()
        {
            Console.WriteLine("Henkilöitä on olemassa: " + instanssit);
        }

        public abstract void Puhu();
    }
}
