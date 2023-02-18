using RebateCalculator.Repositories;
using static RebateCalculator.Commands.SalesCommands;

namespace RebateCalculator.Commands
{
    public class SalesCommands : ISalesCommands
    {
        private readonly ISalesCommandsRepository _repository;
        public SalesCommands(ISalesCommandsRepository repository)
        {
            _repository = repository;
        }
        public void SaveSaleData(Models.Sales sale)
        {
            _repository.SaveSale(sale);
        }
    }
}
