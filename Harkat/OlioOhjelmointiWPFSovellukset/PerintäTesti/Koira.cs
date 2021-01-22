using System;
using System.Collections.Generic;
using System.Text;

namespace PerintäTesti
{
    // Eläimen aliluokka
    class Koira : Eläin
    {

        private static int instanssit = 0;

        public Koira()
        {
            instanssit++;
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("Koiria luotu " + instanssit);
        }

        public override void Ääntele()
        {
            Console.WriteLine("Woof");
        }
    }
}
