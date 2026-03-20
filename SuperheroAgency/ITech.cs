using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal interface ITech
    {
        string Gadget { get; set; }

        public void Hack(string alias)
        {
            Console.WriteLine($"{alias} is hacking into the mainframe");
        }
    }
}
