using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal class Superhero
    {
        string Alias { get; }
        string SecretIdentity { get; }
        int Age { get; }
        Enum Alignment { get; }

        public Superhero(string alias, string secretIdentity, int age, Enum alignment)
        {
            Alias = alias;
            SecretIdentity = secretIdentity;
            Age = age;
            Alignment = alignment;
        }
    }
}

