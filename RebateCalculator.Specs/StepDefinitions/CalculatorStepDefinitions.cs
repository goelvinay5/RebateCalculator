using NUnit.Framework;
using RebateCalculator.DTOs;
using RebateCalculator.Models;
using System;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;

namespace RebateCalculator.Specs.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private readonly RebateCalculator _calculator = new RebateCalculator();
        private List<RebateDTO> _rebateDTOs = new List<RebateDTO>();
        private int _retailerId;

        [Given(@"retailer id (.*)")]
        public void GivenRetailerId(int p0)
        {
            _retailerId = p0;
        }

        [When(@"calculaterebate by retailerId method is called")]
        public void WhenCalculaterebateByRetailerIdMethodIsCalled()
        {
            _rebateDTOs = _calculator.CalculateRebate(_retailerId);
        }

        [Then(@"the retailer details (.*) should be returned")]
        public void ThenTheRetailerDetailsTrueFalseShouldBeReturned(string result)
        {
            StringBuilder sb = new StringBuilder();
            foreach(RebateDTO _dto in _rebateDTOs)
            {
                sb.Append(_dto.RetailerId+",");                
                sb.Append(_dto.RebatePlanId + ",");
                sb.Append(_dto.rebatePercentage + ",");
                sb.Append(_dto.TargetAchieved + ",");
                sb.Append(_dto.CalculatedRebate + ",");
            }

            Assert.AreEqual(sb.ToString(), result+",");
        }
    }
}
