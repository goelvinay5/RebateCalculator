using RebateCalculator.DTOs;
using RebateCalculator.Models;
using RebateCalculator.Queries;

namespace RebateCalculator.Repositories
{
    public class RebateQueriesRepository : IRebateQueriesRepository
    {
        List<Rebate> _rebate = new List<Rebate> {
            new Rebate{ Id = 1, ProductId=1, targetType=Enums.TargetType.Quantity,   Target=10,  Year=2023 },
            new Rebate{ Id = 2, ProductId=2, targetType=Enums.TargetType.Quantity,   Target=10,  Year=2023 },
            //new Rebate{ Id = 3, ProductId=3, targetType=Enums.TargetType.Quantity,   Target=10,  Year=2023 }, // for true condition
            new Rebate{ Id = 3, ProductId=3, targetType=Enums.TargetType.Quantity,   Target=100,  Year=2023 }, // for false condition
            new Rebate{ Id = 4, ProductId=1, targetType=Enums.TargetType.Cost,       Target=1000,  Year=2023 },
            new Rebate{ Id = 5, ProductId=2, targetType=Enums.TargetType.Cost,       Target=1000,  Year=2023 },
            new Rebate{ Id = 6, ProductId=3, targetType=Enums.TargetType.Cost,       Target=1000,  Year=2023 },
        };
        List<Rebate> IRebateQueriesRepository.GetByID(int rebateId)
        {
            return _rebate.FindAll(i => i.Id == rebateId);
        }

        List<RebatePlanDTO> IRebateQueriesRepository.GetAllRebatesByPlanId(int planId)
        {
            var rebateQuery = new RebatePlanQueries(new RebatePlanQueriesRepository());
            List<RebatePlan> rebatePlans = rebateQuery.GetById(planId);
            List<RebatePlanDTO> _dto = new List<RebatePlanDTO>();
            foreach(RebatePlan _plan in rebatePlans)
            {
                var rebate = _rebate.FirstOrDefault(i => i.Id == _plan.RebateID);
                _dto.Add(new RebatePlanDTO
                {
                    Id = rebate.Id,
                    PlanId = _plan.PlanId,
                    ProductId =rebate.ProductId,
                    Target = rebate.Target,
                    targetType = rebate.targetType,
                    Year = rebate.Year
                });
            }
            return _dto;
        }
    }
}
