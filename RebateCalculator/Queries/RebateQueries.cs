using RebateCalculator.Repositories;
using RebateCalculator.DTOs;
using RebateCalculator.Models;

namespace RebateCalculator.Queries
{
    public class RebateQueries
    {
        private readonly IRebateQueriesRepository _repository;
        public RebateQueries(IRebateQueriesRepository repository)
        {
            _repository = repository;
        }
        public List<Rebate> GetByID(int rebateID)
        {
            return _repository.GetByID(rebateID);
        }
        public List<RebatePlanDTO> GetAllRebatesByPlanId(int planId)
        {
            return _repository.GetAllRebatesByPlanId(planId);
        }
    }
}
