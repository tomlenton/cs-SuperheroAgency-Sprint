using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal class HackingMission<ITech> : Mission<ITech>
    {
        public string Location { get; set; }
        public int Reward { get; set; }
        public HackingMission(string location, int reward) : base(location, reward)
        {
            Location = location;
            Reward = reward;
        }
    }
}
