using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController:ControllerBase
{
    [HttpGet]
    public string GetAllProducts()
    {
        return "all products";
    }
    
    [HttpGet("{id}")]
    public string GetProduct(int id)
    {
        return "just one product";
    }
}