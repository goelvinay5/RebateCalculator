using RebateCalculator.Repositories;
using static RebateCalculator.Commands.RebateCommands;

namespace RebateCalculator.Commands
{
    public class RebateCommands : IRebateCommands
    {
        private readonly IRebateCommandsRepository _repository;
        public RebateCommands(IRebateCommandsRepository repository)
        {
            _repository = repository;
        }
        public void SaveRebateData(Models.Rebate rebate)
        {
            _repository.SaveRebate(rebate);
        }
    }
}
