using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RacingChampionship.Model.Common; 

namespace RacingChampionship.Model
{
    public class Contract : BaseModel
    {
        public Team CurrentTeam { get; set; }

        public string Condition { get; set; }

        public DateTime ContractStarts { get; set; }

        public DateTime ContractEnds { get; set; }
    }
}
