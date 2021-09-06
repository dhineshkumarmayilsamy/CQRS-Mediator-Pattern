using API.DataStore.Domain;
using API.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.DataStore.Interface
{
    public interface IDataStore
    {
        Task AddProduct(Product product);
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task EventOccured(Product product, string evt);
    }
}
