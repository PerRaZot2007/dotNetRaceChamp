using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RacingChampionship.Model.Common; 

namespace RacingChampionship.Model
{
    public class Track : BaseModel
    {
        public string Name { get; set; }

        public double LengthOfCourse { get; set; }

        public List<Round> PastEvents { get; set; }

        public Track()
        {
            this.PastEvents = new List<Round>();
        }
    }
}
