using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal class Gadgeteer: Superhero, ITech, IStrength
    {

        public int StrengthLevel { get; set; }
        public string Gadget { get; set; }

        public Gadgeteer(string alias, string secretIdentity, int age, Enum alignment)
            : base(alias, secretIdentity, age, alignment)
        {
            //StrengthLevel = strengthLevel;
            //Gadget = gadget;
        }
    }
}
