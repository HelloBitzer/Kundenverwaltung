using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchnellerKaputtWPF
{
   public class adresse
    {
        string strasse;
        string hausnummer;
        string plz;
        string ort;

        public string Strasse { get => strasse; set => strasse = value; }
        public string Hausnummer { get => hausnummer; set => hausnummer = value; }
        public string Plz { get => plz; set => plz = value; }
        public string Ort { get => ort; set => ort = value; }

        public adresse(string Strasse, string Hausnummer,string PLZ, string Ort)
        {
            strasse = Strasse;
            hausnummer = Hausnummer;
            plz = PLZ;
            ort = Ort;
        }

        public adresse()
        {

        }

        public void Umzug(string Strasse, string Hausnummer, string PLZ, string Ort)
        {
            strasse = Strasse;
            hausnummer = Hausnummer;
            plz = PLZ;
            ort = Ort;
        }


        public override string ToString()
        {
            return strasse + " " + hausnummer + ", " + plz + " " + ort;
        }

    }
}
