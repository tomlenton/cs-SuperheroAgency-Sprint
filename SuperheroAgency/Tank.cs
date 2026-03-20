using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal class Tank: Superhero, IFly, IStrength
    {
        public int StrengthLevel { get; set; }
        public double FlightSpeed { get; set; }
        public double MaxHeight { get; set; }


        public Tank(string alias, string secretIdentity, int age, Enum alignment) 
            : base(alias, secretIdentity, age, alignment )
        {
            //StrengthLevel = strengthLevel;
            //FlightSpeed = flightSpeed;
            //MaxHeight = maxHeight;


        }
    }
}
