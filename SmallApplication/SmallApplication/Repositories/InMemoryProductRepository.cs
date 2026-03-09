using SmallApplication.Models;
using SmallApplication.Repositories.Interfaces;

namespace SmallApplication.Repositories;

public class InMemoryProductRepository : IProductRepository
{
    private readonly List<Product> _products = new();

    public IEnumerable<Product> GetAll() => _products;

    public Product? GetById(int id) 
        => _products.FirstOrDefault(p => p.Id == id);

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public void Update(Product product)
    {
        var existing = GetById(product.Id);
        if (existing != null) return;

        existing.Name = product.Name;
        existing.Price = product.Price;
    }

    public void Delete(int id)
    {
        var product = GetById(id);
        if (product != null)
        {
            _products.Remove(product);
        }
    }
}