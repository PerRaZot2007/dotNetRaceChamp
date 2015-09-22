using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RacingChampionship.Model.Common;

namespace RacingChampionship.Model
{
    public class Champ : BaseModel
    {
        public string Name { get; set; } // название чемпионата

        public int RoundCount { get; set; } // количество этапов

        public List<Round> Rounds { get; set; } // список этапов чемпионата

        public List<Driver> Drivers { get; set; } // список гонщиков, принимающих участие в чемпионате

        public List<Track> Tracks { get; set; } // список треков, принимающих этапы чемпионата

        public Champ()
        {
            this.Rounds = new List<Round>();
            this.Drivers = new List<Driver>();
            this.Tracks = new List<Track>();
        }
    }
}
