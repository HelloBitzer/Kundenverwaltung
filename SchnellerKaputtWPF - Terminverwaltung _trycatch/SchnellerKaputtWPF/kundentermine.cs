using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchnellerKaputtWPF
{
    class kundentermine
    {
        string kundenname;
        termin kundentermin;

        public kundentermine()
        {
        }
        public kundentermine(termin Kundentermin, string Kundenamen)
        {
            kundenname = Kundenamen;
            kundentermin = Kundentermin;
        }

        public string Kundenname { get => kundenname; set => kundenname = value; }
        public termin Kundentermin { get => kundentermin; set => kundentermin = value; }

      
    }
}
