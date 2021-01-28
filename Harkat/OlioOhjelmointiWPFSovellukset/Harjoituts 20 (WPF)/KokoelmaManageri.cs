using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoituts_20__WPF_
{
    static class KokoelmaManageri
    {
        public static Dictionary<string, Opiskelija> Opiskelijat = new Dictionary<string, Opiskelija>();

        public static void LisääOpiskelija(string etunimi, string sukunimi, string opiskelijaID)
        {
            Opiskelijat.Add(opiskelijaID, new Opiskelija(etunimi, sukunimi, opiskelijaID));
        }

        public static bool TarkistaID(string id)
        {
            if (Opiskelijat.ContainsKey(id))
            {
                throw new OpiskelijaPoikkeus("OpiskelijaID " + id + " ei ole uniikki, anna uusi ID");
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Poistetaan opiskelija sanakirjasta annetun indexin avulla.
        /// </summary>
        /// <param name="index"></param>
        public static void PoistaOpiskelija(int syötettyIndex)
        {
            int i = 0;

            foreach (string avain in Opiskelijat.Keys)
            {
                if (i == syötettyIndex)
                {
                    //TulostaViesti("Opiskelija " + Opiskelijat[avain].HaeData() + " poistettu kokoelmasta");
                    Opiskelijat.Remove(avain);
                    break;
                }

                i++;
            }
        }

        public static List<Opiskelija> PalautaOpiskelijat()
        {
            List<Opiskelija> opiskelijatListassa = new List<Opiskelija>();

            opiskelijatListassa.AddRange(Opiskelijat.Values);

            return opiskelijatListassa;
        }
    }
}
