using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebateCalculator.Models
{
    public class RetailerPlan
    {
        //id, reatilerid, rebateplanid
        public int Id { get; set; }
        public int RetailerId{ get; set; }
        public int RebatePlanId { get; set; }
        public int rebatePercentage { get; set; }
    }
}
