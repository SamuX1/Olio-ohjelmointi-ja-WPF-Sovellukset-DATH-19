using System;

namespace AbstractTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija = new Opiskelija();

            Henkilö henkilöOpiskelija = new Opiskelija();

            opiskelija.Puhu();
            henkilöOpiskelija.Puhu();

            Henkilö.KuinkaMonta();
        }
    }
}
