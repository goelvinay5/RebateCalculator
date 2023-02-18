namespace Retailer.API.Repositories
{
    public interface IRetailerQueriesRepository
    {
        Models.Retailer GetByID(int retailerID);
    }
}
