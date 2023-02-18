namespace RebateCalculator.Repositories
{
    public interface ISalesQueriesRepository
    {
        List<Models.Sales> GetByID(int saleId);
    }
}
