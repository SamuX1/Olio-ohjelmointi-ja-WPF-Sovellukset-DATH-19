using System;
using System.Collections.Generic;
using System.Text;

namespace HenkilöStatic
{
    class Henkilö
    {
        private static int instanssit = 0;

        public Henkilö()
        {
            instanssit++;
        }

        public static void KuinkaMontaHenkilöä()
        {
            Console.WriteLine("Henkilöitä olemassa: " + instanssit);
        }

        public void EiStaattinenMetodi()
        {

        }
    }
}
