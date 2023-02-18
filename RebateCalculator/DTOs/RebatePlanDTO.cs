using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebateCalculator.DTOs
{
    public class RebatePlanDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Enums.TargetType targetType { get; set; }
        public int Target { get; set; }
        public int Year { get; set; }
        public int PlanId { get; set; }
    }
}
