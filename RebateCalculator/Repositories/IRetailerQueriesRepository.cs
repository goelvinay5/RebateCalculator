namespace RebateCalculator.Repositories
{
    public interface IRetailerQueriesRepository
    {
        Models.Retailer GetByID(int retailerID);
    }
}
