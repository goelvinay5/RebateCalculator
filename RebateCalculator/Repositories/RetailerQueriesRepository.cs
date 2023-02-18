using RebateCalculator.Models;

namespace RebateCalculator.Repositories
{
    public class RetailerQueriesRepository : IRetailerQueriesRepository
    {
        List<Retailer> _retailer = new List<Retailer> {
            new Retailer{ Id = 1, FullName="vinay" },
            new Retailer{ Id = 2, FullName="goel" }
        };
        Retailer IRetailerQueriesRepository.GetByID(int retailerID)
        {
            return _retailer.FirstOrDefault(i => i.Id == retailerID);
        }
    }
}
