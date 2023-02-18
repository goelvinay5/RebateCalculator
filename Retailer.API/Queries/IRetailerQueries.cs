using Retailer.API.DTOs;

namespace Retailer.API.Queries
{
    public interface IRetailerQueries
    {
        RetailerDTO FindByID(int retailerID);
    }
}
