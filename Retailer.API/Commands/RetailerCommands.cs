using Retailer.API.Repositories;
using static Retailer.API.Commands.RetailerCommands;

namespace Retailer.API.Commands
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
