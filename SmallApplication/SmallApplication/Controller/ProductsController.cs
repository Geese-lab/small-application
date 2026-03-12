using Microsoft.AspNetCore.Mvc;
using SmallApplication.Models;
using SmallApplication.Services.Interfaces;
using SmallApplication.Constants;

namespace SmallApplication.Controller;

[ApiController]
[Route(ApiRoutes.Products)]
public class ProductsController : ControllerBase
{
    private readonly IProductService _service;
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(IProductService service,
                              ILogger<ProductsController> logger)
    {
        _service = service;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        _logger.LogInformation("Getting all products");
        return Ok(_service.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id) 
    {
        var product = _service.GetById(id);
        if (product == null)
            return NotFound();

        return Ok(product);
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        _service.Create(product);
        return Created("", product);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _service.Delete(id);
        return NoContent();
    }
}
