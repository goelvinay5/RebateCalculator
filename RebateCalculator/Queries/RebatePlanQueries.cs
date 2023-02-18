using RebateCalculator.Repositories;

namespace RebateCalculator.Queries
{
    public class RebatePlanQueries
    {
        private readonly IRebatePlanQueriesRepository _repository;
        public RebatePlanQueries(IRebatePlanQueriesRepository repository)
        {
            _repository = repository;
        }
        public List<Models.RebatePlan> GetById(int rebatePlanID)
        {
            return _repository.GetByID(rebatePlanID);
        }
    }
}
