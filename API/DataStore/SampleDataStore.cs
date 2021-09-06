using API.DataStore.Domain;
using API.DataStore.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DataStore
{
    public class SampleDataStore : IDataStore
    {
        private static List<Product> _products;
        public SampleDataStore()
        {
            _products = new List<Product>
        {
            new Product { Id = 1, Name = "Test Product 1" },
            new Product { Id = 2, Name = "Test Product 2" },
            new Product { Id = 3, Name = "Test Product 3" }
        };

        }
        public async Task AddProduct(Product product)
        {
            _products.Add(product);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await Task.FromResult(_products);
        }

        public async Task<Product> GetProductById(int id)
        {
            return await Task.FromResult(_products.Single(p => p.Id == id));
        }

        public async Task EventOccured(Product product, string evt)
        {
            _products.Single(p => p.Id == product.Id).Name = $"{product.Name} evt: {evt}";
            await Task.CompletedTask;
        }
    }
}
