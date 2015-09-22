using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RacingChampionship.Model.Common; 


namespace RacingChampionship.Model.Common
{
    public class Team : BaseModel
    {
        public string Name { get; set; }

        public string Rating { get; set; }

        public List<Driver> CurrentDrivers { get; set; } // действующие гонщики команды

        public Achievement TeamAchievement { get; set; } // достижения команды

        public Team()
        {
            this.CurrentDrivers = new List<Driver>();            
        }
    }
}
