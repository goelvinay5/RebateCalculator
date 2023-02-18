using RebateCalculator.Models;

namespace RebateCalculator.Repositories
{
    public class RebatePlanQueriesRepository : IRebatePlanQueriesRepository
    {
        List<RebatePlan> _rebatePlan = new List<RebatePlan> {
            new RebatePlan{ RebateID = 1, PlanId=1 },
            new RebatePlan{ RebateID = 2, PlanId=2 },
            new RebatePlan{ RebateID = 3, PlanId=2 },
            new RebatePlan{ RebateID = 4, PlanId=3 },
            new RebatePlan{ RebateID = 5, PlanId=4 },
            new RebatePlan{ RebateID = 6, PlanId=4 }
        };
        List<RebatePlan> IRebatePlanQueriesRepository.GetByID(int rebatePlanId)
        {
            return _rebatePlan.FindAll(i => i.PlanId == rebatePlanId);
        }
    }
}
