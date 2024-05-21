using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimRacingManager
{
    public class Player
    {
        public string name { get; set; }
        public string car { get; set; }
        public string skin { get; set; }
    }

    public class Lap
    {
        public int lap { get; set; }
        public int car { get; set; }
        public int[] sectors { get; set; }
        public int time { get; set; }
        public int cuts { get; set; }
        public string tyre { get; set; }
    }

    public class Session
    {
        public string name { get; set; }
        public int type { get; set; }
        public int lapsCount { get; set; }
        public int duration { get; set; }
        public List<Lap> laps { get; set; }
        public int[] lapstotal { get; set; }
        public List<object> bestLaps { get; set; }
    }

    public class Extra
    {
        public string name { get; set; }
        public string guid { get; set; }
        public int max { get; set; }
        public int tier { get; set; }
    }

    public class RaceData
    {
        public string track { get; set; }
        public int number_of_sessions { get; set; }
        public List<Player> players { get; set; }
        public List<Session> sessions { get; set; }
        public List<Extra> extras { get; set; }
    }
}
