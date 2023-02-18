using RebateCalculator.Repositories;
using static RebateCalculator.Commands.RebatePlanCommands;

namespace RebateCalculator.Commands
{
    public class RebatePlanCommands : IRebatePlanCommands
    {
        private readonly IRebatePlanCommandsRepository _repository;
        public RebatePlanCommands(IRebatePlanCommandsRepository repository)
        {
            _repository = repository;
        }
        public void SaveRebatePlanData(Models.RebatePlan rebatePlan)
        {
            _repository.SaveRebatePlan(rebatePlan);
        }
    }
}
