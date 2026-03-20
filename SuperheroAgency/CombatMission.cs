using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    public class CombatMission<IStrength> : Mission<IStrength>
    {
        public string Location { get; set; }
        public int Reward { get; set; }
        public CombatMission(string location, int reward) : base(location, reward)
        {
            Location = location;
            Reward = reward;
        }
    }
}
