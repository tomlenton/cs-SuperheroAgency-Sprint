using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal class RescueMission<T> : Mission<T>
    {
        public string Location { get; set; }
        public int Reward { get; set; }
        public RescueMission(string location, int reward) : base(location, reward)
        {
            Location = location;
            Reward = reward;
        }
    }
}
