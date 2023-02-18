namespace RebateCalculator.Repositories
{
    public interface IRebateQueriesRepository
    {
        List<Models.Rebate> GetByID(int rebateId);

        List<DTOs.RebatePlanDTO> GetAllRebatesByPlanId(int planId);
    }
}
