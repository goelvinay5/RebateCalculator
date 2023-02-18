using RebateCalculator.Repositories;

namespace RebateCalculator.Queries
{
    public class RetailerPlanQueries
    {
        private readonly IRetailerPlanQueriesRepository _repository;
        public RetailerPlanQueries(IRetailerPlanQueriesRepository repository)
        {
            _repository = repository;
        }
        public List<Models.RetailerPlan> GetById(int retailerPlanId)
        {
            return _repository.GetByID(retailerPlanId);
        }
    }
}
