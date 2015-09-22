using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RacingChampionship.Model.Common;

namespace RacingChampionship.Model
{
    public class ChampCatalog : BaseModel
    {
        public List<Champ> Championships { get; set; }

        public ChampCatalog()
        {
            this.Championships = new List<Champ>();
        }
    }
}
