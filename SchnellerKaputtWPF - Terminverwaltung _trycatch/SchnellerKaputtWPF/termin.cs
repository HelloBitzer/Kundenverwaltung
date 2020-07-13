using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchnellerKaputtWPF
{
    public enum Grund
    {
        Reparatur = 1,
        Reifenwechsel =  2,
        Neuwagen_Abholung = 4,
        Service = 8,
        Ölwechsel = 16,
        Inspektion = 32,
        TÜV = 64
    }

    public class termin
    {
        DateTime start;
        DateTime ende;
        string bemerkung;
        bool erledigt;
        Grund termingrund;

        public termin()
        {
        }

        public termin(DateTime Start, DateTime Ende, string Bemerkung,Grund Termingrund)
        {
            start = Start;
            ende = Ende;
            bemerkung = Bemerkung;
            termingrund = Termingrund;
            erledigt = false;
        }

        public DateTime Start { get => start; set => start = value; }
        public DateTime Ende { get => ende; set => ende = value; }
        public string Bemerkung { get => bemerkung; set => bemerkung = value; }
        public bool Erledigt { get => erledigt; set => erledigt = value; }
        public Grund Termingrund { get => termingrund; set => termingrund = value; }

        public override string ToString()
        {
            return start.ToShortDateString() + ", " + start.Hour + ":" + start.Minute + " " + termingrund;
        }
    }
}
