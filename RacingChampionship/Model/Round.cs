using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RacingChampionship.Model.Common; 

namespace RacingChampionship.Model
{
    public class Round : BaseModel
    {
        public string NameOfRound { get; set; }
        
        public Track TrackOfRound { get; set; }

        public Weather WeatherPridiction { get; set; }

        public string TiresCompound { get; set; }  // составы резины, используемые на данном этапе

        public DateTime StartTime { get; set; } // время начала события

        public DateTime EndTime { get; set; } // время окончания события
    }
}
