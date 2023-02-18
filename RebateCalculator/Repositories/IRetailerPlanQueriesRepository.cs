namespace RebateCalculator.Repositories
{
    public interface IRetailerPlanQueriesRepository
    {
        List<Models.RetailerPlan> GetByID(int retailerPlanId);
    }
}
