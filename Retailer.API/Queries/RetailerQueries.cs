using Retailer.API.DTOs;
using Retailer.API.Repositories;

namespace Retailer.API.Queries
{
    public class RetailerQueries
    {
        private readonly IRetailerQueriesRepository _repository;
        public RetailerQueries(IRetailerQueriesRepository repository)
        {
            _repository = repository;
        }
        public RetailerDTO FindByID(int retailerID)
        {
            var ret = _repository.GetByID(retailerID);
            return new RetailerDTO
            {
                Id = ret.Id,
                FullName = ret.FullName
            };
        }
    }
}
