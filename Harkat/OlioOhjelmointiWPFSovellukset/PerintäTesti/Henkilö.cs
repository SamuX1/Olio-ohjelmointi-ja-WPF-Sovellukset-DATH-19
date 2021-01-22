using System;
using System.Collections.Generic;
using System.Text;

namespace PerintäTesti
{
    class Henkilö
    {
        public string Nimi { get; set; }
        public int Ikä { get; set; }

        public virtual void Puhu()
        {
            Console.WriteLine(Nimi + " puhui henkilö luokassa");
        }
    }
}
