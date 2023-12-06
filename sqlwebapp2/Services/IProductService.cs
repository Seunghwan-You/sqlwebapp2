using sqlwebapp2.Models;

namespace sqlwebapp2.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}