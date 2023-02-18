using RebateCalculator.Repositories;

namespace RebateCalculator.Queries
{
    public class SalesQueries
    {
        private readonly ISalesQueriesRepository _repository;
        public SalesQueries(ISalesQueriesRepository repository)
        {
            _repository = repository;
        }
        public List<Models.Sales> GetById(int saleId)
        {
            return _repository.GetByID(saleId);
        }
    }
}
