using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchnellerKaputtWPF
{
    public class kunde : person
    {
        public adresse anschrift;
        public adresse lieferanschrift;
        public DateTime geburtsdatum;
        public string telefonnummer;
        public string email;
      public  List<termin> Termine = new List<termin>();
        public string Name { get => nname + ", " + vname; }

        //public string Nachname { get => base.nname; }
        //public string Vorname { get => base.vname; }
        public adresse Anschrift { get => anschrift; }
        public adresse Lieferanschrift { get => lieferanschrift; }
        public DateTime Geburtsdatum { get => geburtsdatum; }
        public string Telefonnummer { get => telefonnummer;  }
        public string Email { get => email;  }

        public kunde()
        {

        }

        public kunde( string VName, string NName, string Strasse, string Hausnummer, string PLZ, string Ort, adresse Lieferanschrift,string Geburtsdatum, string Telefonnummer, string Email) : base(VName, NName)
        {
            anschrift = new adresse(Strasse, Hausnummer, PLZ, Ort);
            lieferanschrift = Lieferanschrift;
            geburtsdatum = Convert.ToDateTime(Geburtsdatum);
            telefonnummer = Telefonnummer;
            email = Email;

        }
        public kunde(string VName, string NName,adresse Anschrift, adresse Lieferanschrift, string Geburtsdatum, string Telefonnummer, string Email) : base(VName, NName)
        {
            anschrift = Anschrift;
            lieferanschrift = Lieferanschrift;
            geburtsdatum = Convert.ToDateTime(Geburtsdatum);
            telefonnummer = Telefonnummer;
            email = Email;

        }
        public kunde(string VName, string NName, string Strasse, string Hausnummer, string PLZ, string Ort, string Geburtsdatum, string Telefonnummer, string Email) : base(VName, NName)
        {
          
            
            anschrift = new adresse(Strasse, Hausnummer, PLZ, Ort);
            lieferanschrift = anschrift;
            geburtsdatum = Convert.ToDateTime(Geburtsdatum);
            telefonnummer = Telefonnummer;
            email = Email;
      

        }

        public void Kontakdaten_Aendern(string Telefonnummer, string Email)
        {
            telefonnummer = Telefonnummer;
            email = Email;
        }
        public void Kontakdaten_Aendern(int telmail, string datensatz)
        {
            if (telmail == 0)
            {
                telefonnummer = datensatz;
            }
            else
            {
                email = datensatz;
            }          

        }



    }
}
