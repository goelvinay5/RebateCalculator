namespace Retailer.API.Repositories
{
    public class RetailerQueriesRepository : IRetailerQueriesRepository
    {
        Models.Retailer IRetailerQueriesRepository.GetByID(int retailerID)
        {
            return new Models.Retailer()
            {
                Id = 100,
                FullName = "John Smith"
            };
        }
    }
}
