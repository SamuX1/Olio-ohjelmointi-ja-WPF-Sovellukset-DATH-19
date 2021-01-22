using System;

namespace HenkilöStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilö.KuinkaMontaHenkilöä();

            Henkilö henkilö1 = new Henkilö();

            Henkilö.KuinkaMontaHenkilöä();

            Henkilö henkilö2 = new Henkilö();
            Henkilö henkilö3 = new Henkilö();
            Henkilö henkilö4 = new Henkilö();
            Henkilö henkilö5 = new Henkilö();
            Henkilö henkilö6 = new Henkilö();

            Henkilö.KuinkaMontaHenkilöä();
        }
    }
}
