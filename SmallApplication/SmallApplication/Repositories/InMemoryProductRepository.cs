using SmallApplication.Models;
using SmallApplication.Repositories.Interfaces;

namespace SmallApplication.Repositories;

public class InMemoryProductRepository : IProductRepository
{
    private readonly List<Product> _products = new();

    private readonly object _lock = new();

    public IEnumerable<Product> GetAll()
    {
        lock (_lock)
        {
            return _products.ToList();
        }
    }

    public Product? GetById(int id) 
        => _products.FirstOrDefault(p => p.Id == id);

    public void Add(Product product)
    {
        lock (_lock)
        {
            if (_products.Any(p => p.Id == product.Id))
                throw new InvalidOperationException($"A product with Id {product.Id} already exists.");

            _products.Add(product);
        }
    }

    public void Update(Product product)
    {
        lock (_lock)
        {
            var existing = GetById(product.Id);
            if (existing == null) return;

            existing.Name = product.Name;
            existing.Price = product.Price;
        }
    }

    public void Delete(int id)
    {
        lock (_lock)
        {
            var product = GetById(id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}