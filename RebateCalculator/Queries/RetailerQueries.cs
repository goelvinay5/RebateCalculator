using RebateCalculator.Repositories;

namespace RebateCalculator.Queries
{
    public class RetailerQueries
    {
        private readonly IRetailerQueriesRepository _repository;
        public RetailerQueries(IRetailerQueriesRepository repository)
        {
            _repository = repository;
        }
        public Models.Retailer GetById(int retailerID)
        {
            var ret = _repository.GetByID(retailerID);
            return new Models.Retailer
            {
                Id = ret.Id,
                FullName = ret.FullName
            };
        }
    }
}
