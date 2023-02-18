using RebateCalculator.Repositories;
using static RebateCalculator.Commands.RetailerPlanCommands;

namespace RebateCalculator.Commands
{
    public class RetailerPlanCommands : IRetailerPlanCommands
    {
        private readonly IRetailerPlanCommandsRepository _repository;
        public RetailerPlanCommands(IRetailerPlanCommandsRepository repository)
        {
            _repository = repository;
        }
        public void SaveRetailerPlanData(Models.RetailerPlan retailerPlan)
        {
            _repository.SaveRetailerPlan(retailerPlan);
        }
    }
}
