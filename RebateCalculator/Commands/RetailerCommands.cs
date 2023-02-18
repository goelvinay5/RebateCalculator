using RebateCalculator.Repositories;
using static RebateCalculator.Commands.RetailerCommands;

namespace RebateCalculator.Commands
{
    public class RetailerCommands : IRetailerCommands
    {
        private readonly IRetailerCommandsRepository _repository;
        public RetailerCommands(IRetailerCommandsRepository repository)
        {
            _repository = repository;
        }
        public void SaveRetailerData(Models.Retailer retailer)
        {
            _repository.SaveRetailer(retailer);
        }
    }
}
