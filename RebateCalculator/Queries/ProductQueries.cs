using RebateCalculator.Repositories;

namespace RebateCalculator.Queries
{
    public class ProductQueries
    {
        private readonly IProductQueriesRepository _repository;
        public ProductQueries(IProductQueriesRepository repository)
        {
            _repository = repository;
        }
        public Models.Product GetById(int productID)
        {
            var product = _repository.GetByID(productID);
            return new Models.Product
            {
                Id = product.Id,
                Name = product.Name
            };
        }
    }
}
