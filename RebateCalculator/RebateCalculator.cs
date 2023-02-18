using System.Reflection;
using RebateCalculator;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using RebateCalculator.Queries;
using RebateCalculator.Repositories;
using RebateCalculator.Commands;
using RebateCalculator.Models;
using RebateCalculator.DTOs;
using System.Numerics;

namespace RebateCalculator
{
    public class RebateCalculator
    {
        //Given RetailerId
        public List<RebateDTO> CalculateRebate(int retailerId)
        {
            List<RebateDTO> calculatedRebate = new List<RebateDTO>();

            //Get all sales of Retailer
            var salesQuery = new SalesQueries(new SalesQueriesRepository());
            List<Sales> sales = salesQuery.GetById(retailerId);

            // and get all plans of Retailer
            var retailerPlanQuery = new RetailerPlanQueries(new RetailerPlanQueriesRepository());
            List<RetailerPlan> retailerPlans = retailerPlanQuery.GetById(retailerId);

            //and get all rebate conditions(rebateplandtos) for each rebatePlan
            foreach (RetailerPlan plan in retailerPlans)
            {                
                var rebateQuery = new RebateQueries(new RebateQueriesRepository());
                List<RebatePlanDTO> _plandtos = rebateQuery.GetAllRebatesByPlanId(plan.RebatePlanId);

                Boolean isTargetAchieved = true;
                int totalCost = 0;
                //and check for each condition, are the targets achieved in retailer sales
                foreach (RebatePlanDTO _plandto in _plandtos)
                {
                    Sales eligibleSale;
                    if (_plandto.targetType == Enums.TargetType.Cost)
                    {
                        eligibleSale = sales.FirstOrDefault(i => i.ToatlCost >= _plandto.Target && i.ProductId == _plandto.ProductId);                        
                    }
                    else
                    {
                        eligibleSale = sales.FirstOrDefault(i => i.Quantity >= _plandto.Target && i.ProductId == _plandto.ProductId);                        
                    }
                    if (eligibleSale == null)
                    {
                        isTargetAchieved = false;
                    }
                    else { totalCost += eligibleSale.ToatlCost; }
                }
                //and add in rebatedto List
                calculatedRebate.Add(new RebateDTO()
                {
                    RetailerId= retailerId,
                    RebatePlanId = plan.RebatePlanId,
                    rebatePercentage=plan.rebatePercentage,
                    TargetAchieved=isTargetAchieved,
                    CalculatedRebate = isTargetAchieved?(totalCost*plan.rebatePercentage)/100:0
                });
            }


            return calculatedRebate;
        }

    }
}