namespace RebateCalculator.Repositories
{
    public interface IRebatePlanQueriesRepository
    {
        List<Models.RebatePlan> GetByID(int rebatePlanId);
    }
}
