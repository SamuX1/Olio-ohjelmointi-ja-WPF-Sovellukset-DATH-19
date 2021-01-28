using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoituts_20__WPF_
{
    class Opiskelija
    {
        private string etunimi;
        private string sukunimi;
        private string opiskelijaID;

        public string OpiskelijaID { get => opiskelijaID; set => opiskelijaID = value; }
        public string Sukunimi { get => sukunimi; set => sukunimi = value; }
        public string Etunimi { get => etunimi; set => etunimi = value; }
        public bool Valittu { get; set; }


        public Opiskelija(string etunimi, string sukunimi, string opiskelijaID)
        {
            this.Etunimi = etunimi;
            this.Sukunimi = sukunimi;
            this.OpiskelijaID = opiskelijaID;
            Valittu = false;
        }


        public string HaeData()
        {
            return Etunimi + " " + Sukunimi + ". ID: " + OpiskelijaID;
        }
    }
}
