using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddictingChoresProject.Models
{

    public class Reward
    {
        public int RewardId { get; set; }
        public string RewardTitle { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
        public int Cost { get; set; }
        public ValueType? CostType { get; set; }

    }
}