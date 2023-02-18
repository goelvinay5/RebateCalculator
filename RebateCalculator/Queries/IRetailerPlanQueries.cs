namespace RebateCalculator.Queries
{
    public interface IRetailerPlanQueries
    {
        List<Models.RetailerPlan> GetById(int retailerPlanId);
    }
}
