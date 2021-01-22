using System;
using System.Collections.Generic;
using System.Text;

namespace PerintäTesti
{
    class Opiskelija : Henkilö
    {
        public string OpiskelijaID { get; set; }

        public override void Puhu()
        {
            Console.WriteLine(Nimi + " puhui Opiskelija luokassa");
        }
    }
}
