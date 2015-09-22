using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RacingChampionship.Model.Common; 

namespace RacingChampionship.Model
{
    public class Achievement : BaseModel
    {
        public int winsCount { get; set; }
        
        public int podiumsCount { get; set; }

        public double overallPoints { get; set; }
    }
}
