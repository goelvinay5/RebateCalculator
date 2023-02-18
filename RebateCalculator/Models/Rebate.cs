using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebateCalculator.Models
{
    public class Rebate
    {
        //id, productid, TargetType(qty, cost), Target, add rebate, get rebate
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Enums.TargetType targetType { get; set; }
        public int Target { get; set; }
        public int Year { get; set; }
    }
}
