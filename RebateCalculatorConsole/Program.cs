// See https://aka.ms/new-console-template for more information
using RebateCalculator;
using RebateCalculator.DTOs;

Console.WriteLine("Hello, World!");

RebateCalculator.RebateCalculator rebateCalculator = new RebateCalculator.RebateCalculator();
var rebates = rebateCalculator.CalculateRebate(1);
foreach(RebateDTO rebate in rebates)
{
    Console.Write(rebate.RetailerId + " |");
    Console.Write(rebate.RebatePlanId + " |");
    Console.Write(rebate.rebatePercentage + " |");
    Console.Write(rebate.TargetAchieved + " |");
    Console.Write(rebate.CalculatedRebate + " |");
    Console.WriteLine();
}

rebates = rebateCalculator.CalculateRebate(2);
foreach (RebateDTO rebate in rebates)
{
    Console.Write(rebate.RetailerId + " |");
    Console.Write(rebate.RebatePlanId + " |");
    Console.Write(rebate.rebatePercentage + " |");
    Console.Write(rebate.TargetAchieved + " |");
    Console.Write(rebate.CalculatedRebate + " |");
    Console.WriteLine();
}
