using RebateCalculator.Commands;
using RebateCalculator.Queries;
using RebateCalculator.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebateCalculator
{
    public class RetailerService
    {
        public Models.Retailer GetRetailer(int id)
        {
            var employeeQuery = new RetailerQueries(new RetailerQueriesRepository());
            Models.Retailer retailer = employeeQuery.GetById(id);
            return retailer;
        }

        public void SaveRetailer(Models.Retailer retailer)
        {
            var employeeCommand = new RetailerCommands(new RetailerCommandsRepository());
            employeeCommand.SaveRetailerData(retailer);
        }
    }
}
