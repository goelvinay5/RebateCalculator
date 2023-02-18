using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebateCalculator.DTOs
{
    public class RebateDTO
    {
        public int RetailerId { get; set; }
        public int RebatePlanId { get; set; }
        public int rebatePercentage { get; set; }
        public Boolean TargetAchieved { get; set; }
        public int CalculatedRebate { get; set; }
    }
}
