using Moq;
using SmallApplication.Models;
using SmallApplication.Repositories.Interfaces;
using SmallApplication.Services;

namespace SmallApplication.Tests;

public class ProductServiceTests
{
    [Fact]
    public void GetAll_ShouldReturnProducts()
    {
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1000 },
            new Product { Id = 2, Name = "Mouse", Price = 50 }
        };

        var repoMock = new Mock<IProductRepository>();
        repoMock.Setup(r => r.GetAll()).Returns(products);

        var service = new ProductService(repoMock.Object);

        var result = service.GetAll();

        Assert.Equal(2, result.Count());
    }

    [Fact]
    public void Create_ShouldCallRepositoryAdd()
    {
        var repoMock = new Mock<IProductRepository>();

        var service = new ProductService(repoMock.Object);

        var product = new Product
        {
            Id = 1,
            Name = "Keyboard",
            Price = 80
        };

        service.Create(product);

        repoMock.Verify(r => r.Add(product), Times.Once);
    }

    [Fact]
    public void GetById_ShouldReturnProduct_WhenExists()
    {
        var product = new Product { Id = 1, Name = "Monitor", Price = 300 };

        var repoMock = new Mock<IProductRepository>();
        repoMock.Setup(r => r.GetById(1)).Returns(product);

        var service = new ProductService(repoMock.Object);

        var result = service.GetById(1);

        Assert.NotNull(result);
        Assert.Equal("Monitor", result.Name);
    }


}