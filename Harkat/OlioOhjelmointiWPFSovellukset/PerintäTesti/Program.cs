using System;

namespace PerintäTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilö henkilö = new Henkilö();
            henkilö.Nimi = "Matti";

            henkilö.Puhu();

            Opiskelija opiskelija = new Opiskelija();
            opiskelija.Nimi = "Pekka";

            opiskelija.Puhu();

            Eläin.KuinkaMonta();

            Koira koira1 = new Koira();
            koira1.Ääntele();

            Kissa kissa1 = new Kissa();
            kissa1.Ääntele();

            Eläin.KuinkaMonta();

            Koira koira2 = new Koira();
            Koira koira3 = new Koira();
            Kissa kissa2 = new Kissa();

            Koira.KuinkaMonta();
            Kissa.KuinkaMonta();
            Eläin.KuinkaMonta();
        }
    }
}
