using RebateCalculator.Models;

namespace RebateCalculator.Repositories
{
    public class RetailerPlanQueriesRepository : IRetailerPlanQueriesRepository
    {
        List<RetailerPlan> _retailerPlan = new List<RetailerPlan> {
            new RetailerPlan{ Id = 1, RebatePlanId=1, RetailerId = 1, rebatePercentage=10 },
            new RetailerPlan{ Id = 1, RebatePlanId=2, RetailerId = 1, rebatePercentage=8 },
            new RetailerPlan{ Id = 1, RebatePlanId=3, RetailerId = 2, rebatePercentage=10 },
            new RetailerPlan{ Id = 1, RebatePlanId=4, RetailerId = 2, rebatePercentage=8 },
        };
        List<RetailerPlan> IRetailerPlanQueriesRepository.GetByID(int retailerId)
        {
            return _retailerPlan.FindAll(i => i.RetailerId == retailerId);
        }
    }
}
