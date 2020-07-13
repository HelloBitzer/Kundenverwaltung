using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchnellerKaputtWPF
{
    public abstract class person
    {
        public string nname;
        public string vname;

        //public string Nname { get => nname; }
        //public string Vname { get => vname; }

        public person()
        {

        }

        public person(string VName, string NName)
        {
            nname = NName;
            vname = VName;
        }

        protected void Hochzeit(string NName)
        {
            nname = NName;
        }

    }
}
