using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RacingChampionship.Model.Common; 

namespace RacingChampionship.Model
{
    public class Driver : BaseModel
    {
        public string Name { get; set; }

        public Achievement DriverAchievement { get; set; }

        public List<Contract> CurrentContracts { get; set; }

        public Driver()
        {
            this.CurrentContracts = new List<Contract>();
        }
    }
}
