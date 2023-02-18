namespace RebateCalculator.Repositories
{
    public interface IProductQueriesRepository
    {
        Models.Product GetByID(int productId);
    }
}
