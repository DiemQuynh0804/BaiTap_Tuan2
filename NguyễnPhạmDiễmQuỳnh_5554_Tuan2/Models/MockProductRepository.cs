
using System.Linq;

namespace NguyễnPhạmDiễmQuỳnh_5554_Tuan2.Models
{
    public class MockProductRepository : IProductRepository
    {

        private readonly List<Product> _products;
        public MockProductRepository()
        {
            _products = new List<Product>
            {
                new Product { Id = 1,
                              Name = "Laptop",
                              Price = 1000,
                              Description = "A high-end laptop"}
            };

        }
        public void Add(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
        }

        public void Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(product => product.Id == id);
        }

        public void Update(Product product)
        {
            var index =_products.FindIndex(p => p.Id == product.Id);
            if (index != -1) 
            {
                _products[index] = product;
            }
        }
    }
}
