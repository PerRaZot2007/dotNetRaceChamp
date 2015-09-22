using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RacingChampionship.Model.Common; 


namespace RacingChampionship.Model
{
    public class Weather : BaseModel
    {
        public float Temperatur { get; set; }

        public float Cloud { get; set; }

        public float RainChance { get; set; }
    }
}
