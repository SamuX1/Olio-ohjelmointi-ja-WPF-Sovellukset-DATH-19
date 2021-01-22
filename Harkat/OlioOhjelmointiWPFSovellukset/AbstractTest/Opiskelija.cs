using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractTest
{
    class Opiskelija : Henkilö
    {
        public override string Nimi { get; set; }

        public override void Puhu()
        {
            Console.WriteLine("Opiskelija puhuu Opiskelija -luokassa, joka perii metodin abstraktista Henkilö luokasta");
        }
    }
}
