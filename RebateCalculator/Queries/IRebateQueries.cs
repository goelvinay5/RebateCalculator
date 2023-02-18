namespace RebateCalculator.Queries
{
    public interface IRebateQueries
    {
        List<Models.Rebate> GetById(int rebateId);
        List<DTOs.RebatePlanDTO> GetAllRebatesByPlanId(int planId);
    }
}
