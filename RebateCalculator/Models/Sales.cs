using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebateCalculator.Models
{
    public class Sales
    {
        //id, retailer id, productid, qty, cost, total cost, year,
        public int Id { get; set; }
        public int RetailerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; }
        public int ToatlCost { get; set; }
        public int Year { get; set; }

    }
}
