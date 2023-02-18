using RebateCalculator.Models;

namespace RebateCalculator.Repositories
{
    public class SalesQueriesRepository : ISalesQueriesRepository
    {
        List<Sales> _sales = new List<Sales> {
            new Sales{ Id=1, RetailerId =1, ProductId=1, Quantity=10, Cost=100, ToatlCost=1000, Year=2023 },
            new Sales{ Id=2, RetailerId =1, ProductId=2, Quantity=20, Cost=200, ToatlCost=4000, Year=2023 },
            new Sales{ Id=3, RetailerId =1, ProductId=3, Quantity=30, Cost=300, ToatlCost=9000, Year=2023 },
            new Sales{ Id=4, RetailerId =2, ProductId=1, Quantity=10, Cost=100, ToatlCost=1000, Year=2023 },
            new Sales{ Id=5, RetailerId =2, ProductId=2, Quantity=20, Cost=200, ToatlCost=4000, Year=2023 },
            new Sales{ Id=6, RetailerId =2, ProductId=3, Quantity=30, Cost=300, ToatlCost=9000, Year=2023 }
        };
        List<Sales> ISalesQueriesRepository.GetByID(int retailerId)
        {
            return _sales.FindAll(i => i.RetailerId == retailerId);
        }
    }
}
