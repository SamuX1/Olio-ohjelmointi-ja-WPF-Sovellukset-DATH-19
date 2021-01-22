using System;

namespace StaticTest
{
    class Program
    {
        static void Main(string[] args)
        {
            float kilometri = 60f;

            float mailit = StaattinenLuokka.KmToMiles(kilometri);

            Console.WriteLine("{0}km/h on yhtäkuin {1} mailia", kilometri, mailit);
        }
    }
}
