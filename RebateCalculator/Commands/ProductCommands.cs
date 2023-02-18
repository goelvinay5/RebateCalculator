using RebateCalculator.Repositories;
using static RebateCalculator.Commands.ProductCommands;

namespace RebateCalculator.Commands
{
    public class ProductCommands : IProductCommands
    {
        private readonly IProductCommandsRepository _repository;
        public ProductCommands(IProductCommandsRepository repository)
        {
            _repository = repository;
        }
        public void SaveProductData(Models.Product product)
        {
            _repository.SaveProduct(product);
        }
    }
}
