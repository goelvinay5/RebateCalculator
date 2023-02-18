using System.Collections.Generic;

namespace RebateCalculator.Repositories
{
    public class ProductQueriesRepository : IProductQueriesRepository
    {
        List<Models.Product> _products = new List<Models.Product> {
            new Models.Product{ Id = 1, Name="X" },
            new Models.Product{ Id = 2, Name="Y" },
            new Models.Product{ Id = 3, Name="Z" }
        };
        
        Models.Product IProductQueriesRepository.GetByID(int productId)
        {
            return _products.FirstOrDefault(i => i.Id == productId);
        }
    }
}
