using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RacingChampionship.Model.Common
{
    public abstract class BaseModel
    {
        public int Id { get; set; }

        public int rating { get; set; }
    }
}
